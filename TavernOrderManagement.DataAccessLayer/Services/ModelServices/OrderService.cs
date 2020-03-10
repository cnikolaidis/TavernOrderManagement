namespace TavernOrderManagement.DataAccessLayer.Services.ModelServices
{
    #region Usings
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Models.Dtos;
    using System.Data;
    using Utilities;
    using System;
    #endregion

    public interface IOrderService : IBaseService<OrderDto, OrderCriteriaDto> {}

    public class OrderService : BaseService<OrderDto, OrderCriteriaDto>, IOrderService
    {
        public override int Create(OrderDto order)
        {
            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery(@"INSERT INTO orderList (orderTable, orderDate, orderTime, orderSumPrice) VALUES" +
                    $"({order.Table}, '{order.DateCreated.ToString("dd/MM/yyyy")}', '{order.DateCreated.ToString("HH:mm:ss")}', {order.TotalAmount});");

            var entitySaved = ListByCriteria(new OrderCriteriaDto
            {
                Table = order.Table,
                TotalAmount = order.TotalAmount,
                DateCreated = order.DateCreated
            }).FirstOrDefault();

            return entitySaved?.Id ?? 0;
        }

        public override void Update(OrderDto order)
        {
            var existingEntity = ListByCriteria(new OrderCriteriaDto { Id = order.Id, Table = order.Table })
                .FirstOrDefault();

            if (existingEntity == null)
                return;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"UPDATE orderList SET orderDate = '{order.DateCreated.ToString("dd/MM/yyyy")}', orderTime = '{order.DateCreated.ToString("HH:mm:ss")}', orderSumPrice = {order.TotalAmount} WHERE orderID = {order.Id} AND orderTable = {order.Table};");
        }

        public override void Delete(OrderDto order)
        {
            var existingEntity = ListByCriteria(new OrderCriteriaDto { Id = order.Id })
                .FirstOrDefault();

            if (existingEntity == null)
                return;

            using (var sqlSvc = new SqLiteService())
                sqlSvc.ExecuteQuery($"DELETE FROM orderList WHERE orderID = {existingEntity.Id};");
        }

        #region Private Methods
        protected override string CreateSqlQuery(OrderCriteriaDto criteria)
        {
            string sqlQuery = @"SELECT * FROM orderList";
            var whereQueries = new List<string>();

            if (criteria.Id != 0)
                whereQueries.Add($"(orderID = {criteria.Id})");
            if (criteria.Ids != null && criteria.Ids.Any())
                whereQueries.Add($"(orderID IN ({string.Join(@",", criteria.Ids)}))");
            if (criteria.Table != 0)
                whereQueries.Add($"(orderTable = {criteria.Table})");
            if (criteria.Tables != null && criteria.Tables.Any())
                whereQueries.Add($"(orderTable IN ({string.Join(@",", criteria.Tables)}))");
            if (criteria.TotalAmount != 0)
                whereQueries.Add($"(orderSumPrice = {criteria.TotalAmount})");
            if (criteria.DateCreated != null)
                whereQueries.Add($"(substr(orderDate, 0, 3) = '{criteria.DateCreated.Value.Day}'" +
                    $"AND substr(orderDate, 4, 2) = '{criteria.DateCreated.Value.Month}' " +
                    $"AND substr(orderDate, 7, 12) = '{criteria.DateCreated.Value.Year}')");
            if (criteria.DateFrom != null)
                whereQueries.Add(@"(date(substr(orderDate, 7, 12) || '-' || " +
                                 @"substr(orderDate, 4, 2) || '-' || substr(orderDate, 0, 3)) " +
                                 $">= date(substr('{criteria.DateFrom.Value.Date.ToString(@"dd-MM-yyyy")}', 7, 12) " +
                                 $"|| '-' || substr('{criteria.DateFrom.Value.Date.ToString(@"dd-MM-yyyy")}', 4, 2) " +
                                 $"|| '-' || substr('{criteria.DateFrom.Value.Date.ToString(@"dd-MM-yyyy")}', 0, 3)))");
            if (criteria.DateTo != null)
                whereQueries.Add(@"(date(substr(orderDate, 7, 12) || '-' || " +
                                 @"substr(orderDate, 4, 2) || '-' || substr(orderDate, 0, 3)) " +
                                 $"<= date(substr('{criteria.DateTo.Value.Date.ToString(@"dd-MM-yyyy")}', 7, 12) " +
                                 $"|| '-' || substr('{criteria.DateTo.Value.Date.ToString(@"dd-MM-yyyy")}', 4, 2) " +
                                 $"|| '-' || substr('{criteria.DateTo.Value.Date.ToString(@"dd-MM-yyyy")}', 0, 3)))");

            sqlQuery += whereQueries.Any()
                ? $" WHERE ({string.Join(@" AND ", whereQueries)});"
                : @";";

            return sqlQuery;
        }

        protected override OrderDto ConstructEntity(DataRow x)
        {
            try
            {
                var dateString = $"{x.ItemArray[2]} {x.ItemArray[3]}";
                DateTime.TryParseExact(dateString, @"dd/MM/yyyy HH:mm:ss", new CultureInfo(@"en-US"), DateTimeStyles.AdjustToUniversal, out var rowDate);

                return new OrderDto
                {
                    Id = x.ItemArray[0].ToInt(),
                    Table = x.ItemArray[1].ToInt(),
                    DateCreated = rowDate,
                    TotalAmount = x.ItemArray[4].ToDecimal()
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
