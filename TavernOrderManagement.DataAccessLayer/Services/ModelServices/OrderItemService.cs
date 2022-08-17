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

    public interface IOrderItemService : IBaseService<OrderItemDto, OrderItemCriteriaDto> { }

    public class OrderItemService : BaseService<OrderItemDto, OrderItemCriteriaDto>, IOrderItemService
    {
        public override int Create(OrderItemDto orderItem)
        {
            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery(@"INSERT INTO orders (orderID, orderedItemID, orderedItemQuantity, orderedItemName, orderedItemPrice) VALUES " +
                    $"({orderItem.OrderId}, {orderItem.Id}, {orderItem.Quantity}, '{orderItem.Name}', {orderItem.Price});");

            var entitySaved = ListByCriteria(new OrderItemCriteriaDto
            {
                OrderId = orderItem.OrderId,
                Id = orderItem.Id,
                Name = orderItem.Name,
                Price = orderItem.Price,
                Quantity = orderItem.Quantity
            }).FirstOrDefault();

            return entitySaved?.Id ?? 0;
        }

        public override void Update(OrderItemDto orderItem)
        {
            var existingEntity = ListByCriteria(new OrderItemCriteriaDto { Id = orderItem.Id, OrderId = orderItem.OrderId })
                .FirstOrDefault();

            if (existingEntity == null)
                return;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"UPDATE orders SET orderedItemQuantity = '{orderItem.Quantity}', orderedItemName = '{orderItem.Name}'," +
                    $" orderedItemPrice = {orderItem.Price} WHERE orderedItemID = {orderItem.Id} AND orderID = {orderItem.OrderId};");
        }

        public override void Delete(OrderItemDto orderItem)
        {
            var existingEntity = ListByCriteria(new OrderItemCriteriaDto { Id = orderItem.Id, OrderId = orderItem.OrderId })
                .FirstOrDefault();

            if (existingEntity == null)
                return;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"DELETE FROM orders WHERE orderID = {existingEntity.OrderId} AND orderedItemID = {existingEntity.Id};");
        }

        #region Private Methods
        protected override string CreateSqlQuery(OrderItemCriteriaDto criteria)
        {
            var sqlQuery = @"SELECT * FROM orders";
            var whereQueries = new List<string>();

            if (criteria.Id != 0)
                whereQueries.Add($"(orderedItemID = {criteria.Id})");
            if (criteria.Ids != null && criteria.Ids.Any())
                whereQueries.Add($"(orderedItemID IN ({string.Join(@",", criteria.Id)}))");
            if (criteria.OrderId != 0)
                whereQueries.Add($"(orderID = {criteria.OrderId})");
            if (criteria.OrderIds != null && criteria.OrderIds.Any())
                whereQueries.Add($"(orderID IN ({string.Join(@",", criteria.OrderIds)}))");
            if (!criteria.Name.IsEmpty())
                whereQueries.Add($"(orderedItemName = '{criteria.Name}')");

            sqlQuery += whereQueries.Any()
                ? $" WHERE ({string.Join(@" AND ", whereQueries)});"
                : @";";

            return sqlQuery;
        }

        protected override OrderItemDto ConstructEntity(DataRow x)
        {
            try
            {
                var itemId = x.ItemArray[1].ToInt();
                var itemName = x.ItemArray.Length > 3 ? x.ItemArray[3].ToString() : string.Empty;
                var itemPrice = x.ItemArray.Length > 3 ? x.ItemArray[4].ToDecimal() : 0;

                if (!itemName.IsEmpty() && itemPrice != 0)
                    return new OrderItemDto
                    {
                        Id = x.ItemArray[1].ToInt(),
                        OrderId = x.ItemArray[0].ToInt(),
                        Quantity = x.ItemArray[2].ToDecimal(),
                        Name = itemName,
                        Price = itemPrice
                    };

                var productForItem = S.ProductService
                    .ListByCriteria(new ProductCriteriaDto { Id = itemId })
                    .FirstOrDefault();

                if (productForItem == null)
                    return new OrderItemDto
                    {
                        Id = x.ItemArray[1].ToInt(),
                        OrderId = x.ItemArray[0].ToInt(),
                        Quantity = x.ItemArray[2].ToDecimal(),
                        Name = itemName,
                        Price = itemPrice
                    };

                itemName = productForItem.Name;
                itemPrice = productForItem.Price;

                return new OrderItemDto
                {
                    Id = x.ItemArray[1].ToInt(),
                    OrderId = x.ItemArray[0].ToInt(),
                    Quantity = x.ItemArray[2].ToDecimal(),
                    Name = itemName,
                    Price = itemPrice
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
