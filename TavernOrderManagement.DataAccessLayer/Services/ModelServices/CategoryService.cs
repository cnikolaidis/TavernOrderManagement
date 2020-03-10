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

    public interface ICategoryService : IBaseService<CategoryDto, CategoryCriteriaDto> { }

    public class CategoryService : BaseService<CategoryDto, CategoryCriteriaDto>, ICategoryService
    {
        public override int Create(CategoryDto category)
        {
            var existingEntity = ListByCriteria(new CategoryCriteriaDto {Name = category.Name})
                .FirstOrDefault();

            if (existingEntity != null)
                return 0;

            using (SqLiteService sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"INSERT INTO itemCategories (categoryName) VALUES ('{category.Name}');");

            var entitySaved = ListByCriteria(new CategoryCriteriaDto { Name = category.Name }).FirstOrDefault();

            return entitySaved?.Id ?? 0;
        }

        public override void Update(CategoryDto category)
        {
            var existingEntity = ListByCriteria(new CategoryCriteriaDto { Id = category.Id })
                .FirstOrDefault();

            if (existingEntity == null)
                return;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"UPDATE itemCategories SET categoryName = '{category.Name}' WHERE categoryID = {existingEntity.Id};");
        }

        public override void Delete(CategoryDto category)
        {
            var existingEntity = ListByCriteria(new CategoryCriteriaDto { Id = category.Id })
                .FirstOrDefault();

            if (existingEntity == null)
                return;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"DELETE FROM itemCategories WHERE categoryID = {existingEntity.Id};");
        }

        #region Private Methods
        protected override string CreateSqlQuery(CategoryCriteriaDto criteria)
        {
            string sqlQuery = @"SELECT * FROM itemCategories";
            var whereQueries = new List<string>();

            if (criteria.Id != 0)
                whereQueries.Add($"(categoryID = {criteria.Id})");
            if (criteria.Ids != null && criteria.Ids.Any())
                whereQueries.Add($"(categoryID IN {string.Join(@",", criteria.Ids)})");
            if (!criteria.Name.IsEmpty())
                whereQueries.Add($"(categoryName = '{criteria.Name}')");

            sqlQuery += whereQueries.Any()
                ? $" WHERE ({string.Join(@" AND ", whereQueries)});"
                : @";";

            return sqlQuery;
        }

        protected override CategoryDto ConstructEntity(DataRow x)
        {
            try
            {
                return new CategoryDto
                {
                    Id = x.ItemArray[0].ToInt(),
                    Name = x.ItemArray[1].ToString()
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
