namespace TavernOrderManagement.DataAccessLayer.Services.ModelServices
{
    #region Usings
    using System.Collections.Generic;
    using System.Linq;
    using Models.Dtos;
    using System.Data;
    using Utilities;
    using System;
    #endregion

    public interface IProductService : IBaseService<ProductDto, ProductCriteriaDto> {}

    public class ProductService : BaseService<ProductDto, ProductCriteriaDto>, IProductService
    {
        public override int Create(ProductDto product)
        {
            var existingEntity = ListByCriteria(new ProductCriteriaDto { Name = product.Name, Category = product.Category, FixedQuantity = product.FixedQuantity })
                .FirstOrDefault();

            if (existingEntity != null)
                return 0;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery(@"INSERT INTO items (dateCreated, timeCreated, itemName, itemCategory, fixedQuantity, itemPrice)" +
                    $" VALUES ('{product.DateCreated}', '{product.DateCreated}', '{product.Name}', '{product.Category}', '{product.FixedQuantity}', {product.Price});");

            var entitySaved = ListByCriteria(new ProductCriteriaDto
            {
                Name = product.Name,
                Category = product.Category
            }).FirstOrDefault();

            return entitySaved?.Id ?? 0;
        }

        public override void Update(ProductDto product)
        {
            var existingEntity = ListByCriteria(new ProductCriteriaDto { Id = product.Id })
                .FirstOrDefault();

            if (existingEntity == null)
                return;
            
            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"UPDATE items SET dateCreated = '{product.DateCreated}', timeCreated = '{product.DateCreated}', itemName = '{product.Name}', itemCategory = '{product.Category}', fixedQuantity = '{product.FixedQuantity}', itemPrice = {product.Price} WHERE itemID = {product.Id};");
        }

        public override void Delete(ProductDto product)
        {
            var existingEntity = ListByCriteria(new ProductCriteriaDto { Id = product.Id })
                .FirstOrDefault();

            if (existingEntity == null)
                return;
            
            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"DELETE FROM items WHERE itemID = {existingEntity.Id};");
        }

        #region Private Methods
        protected override string CreateSqlQuery(ProductCriteriaDto criteria)
        {
            var sqlQuery = @"SELECT * FROM items";
            var whereQueries = new List<string>();
            var fqYesStr = @"Ναί";
            var fqNoStr = @"Όχι";

            if (criteria.Id != 0)
                whereQueries.Add($"(itemID = {criteria.Id})");
            if (criteria.Ids != null && criteria.Ids.Any())
                whereQueries.Add($"(itemID IN {string.Join(@",", criteria.Ids)})");
            if (!criteria.Name.IsEmpty())
                whereQueries.Add($"(itemName = '{criteria.Name}')");
            if (!criteria.NameContains.IsEmpty())
                whereQueries.Add($"(itemName LIKE '%{criteria.NameContains.ToUpperInvariant()}%')");
            if (!criteria.Category.IsEmpty())
                whereQueries.Add($"(itemCategory = '{criteria.Category}')");
            if (criteria.FixedQuantity != null)
            {
                string strToPass = criteria.FixedQuantity.Value ? fqYesStr : fqNoStr;
                whereQueries.Add($"(fixedQuantity = '{strToPass}')");
            }
            if (criteria.DateFrom != null)
                whereQueries.Add(@"(date(substr(dateCreated, 7, 12) || '-' || " +
                                 @"substr(dateCreated, 4, 2) || '-' || substr(dateCreated, 0, 3)) " +
                                 $">= date(substr('{criteria.DateFrom.Value.Date.ToString(@"dd-MM-yyyy")}', 7, 12) " +
                                 $"|| '-' || substr('{criteria.DateFrom.Value.Date.ToString(@"dd-MM-yyyy")}', 4, 2) " +
                                 $"|| '-' || substr('{criteria.DateFrom.Value.Date.ToString(@"dd-MM-yyyy")}', 0, 3)))");
            if (criteria.DateTo != null)
                whereQueries.Add(@"(date(substr(dateCreated, 7, 12) || '-' || " +
                                 @"substr(dateCreated, 4, 2) || '-' || substr(dateCreated, 0, 3)) " +
                                 $"<= date(substr('{criteria.DateTo.Value.Date.ToString(@"dd-MM-yyyy")}', 7, 12) " +
                                 $"|| '-' || substr('{criteria.DateTo.Value.Date.ToString(@"dd-MM-yyyy")}', 4, 2) " +
                                 $"|| '-' || substr('{criteria.DateTo.Value.Date.ToString(@"dd-MM-yyyy")}', 0, 3)))");

            sqlQuery += whereQueries.Any()
                ? $" WHERE ({string.Join(@" AND ", whereQueries)});"
                : @";";

            return sqlQuery;
        }

        protected override ProductDto ConstructEntity(DataRow x)
        {
            try
            {
                var dateString = $"{x.ItemArray[1]} {x.ItemArray[2]}";
                DateTime.TryParse(dateString, out var rowDate);

                return new ProductDto
                {
                    Id = x.ItemArray[0].ToInt(),
                    DateCreated = rowDate,
                    Name = x.ItemArray[3].ToString(),
                    Category = x.ItemArray[4].ToString(),
                    FixedQuantity = x.ItemArray[5].ToString().Equals(@"Ναί"), //TODO: STUPID FIX
                    Price = x.ItemArray[6].ToDecimal()
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
