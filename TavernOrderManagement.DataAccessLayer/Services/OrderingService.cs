namespace TavernOrderManagement.DataAccessLayer.Services
{
    #region Usings
    using System.Collections.Generic;
    using ModelServices;
    using System.Linq;
    using Models.Dtos;
    using System;
    #endregion

    public class OrderingService
    {
        #region Properties
        public static List<OrderDto> PendingOrders = new List<OrderDto>();
        #endregion

        #region Public Service Methods
        public static OrderDto GetTableOrder(int tblId)
        {
            var tableOrder = PendingOrders
                .FirstOrDefault(x => x.Table == tblId);

            return tableOrder;
        }

        public static decimal GetTodaysSum()
        {
            var dateToday = DateTime.Now.Date;
            var todayOrderSum = S.OrderService
                .ListByCriteria(new OrderCriteriaDto {DateCreated = dateToday})
                .Sum(x => x.TotalAmount);

            return todayOrderSum;
        }

        public static void SetupOrder(int tblId, OrderItemDto orderItem)
        {
            var tableOrder = GetTableOrder(tblId);
            if (tableOrder != null)
            {
                var itemExists = tableOrder.OrderItems.FirstOrDefault(x => x.Id == orderItem.Id);
                if (itemExists != null)
                {
                    foreach (var item in tableOrder.OrderItems)
                    {
                        if (item.Id == orderItem.Id)
                            item.Quantity += orderItem.Quantity;
                    }
                }
                else
                {
                    foreach (var order in PendingOrders)
                    {
                        if (order.Table == tblId)
                            order.OrderItems.Add(orderItem);
                    }
                }

                var itemsAmount = tableOrder.OrderItems.Sum(x => x.Price * x.Quantity);
                tableOrder.TotalAmount = itemsAmount;
            }
            else
            {
                PendingOrders.Add(new OrderDto
                {
                    Table = tblId,
                    OrderItems = new List<OrderItemDto> { orderItem },
                    DateCreated = DateTime.Now,
                    TotalAmount = orderItem.Price * orderItem.Quantity
                });
            }

            XmlStateService.SaveOrdersState(PendingOrders);
        }

        public static void RemoveItemFromOrder(int tblId, string itemName)
        {
            var tableOrder = GetTableOrder(tblId);
            if (tableOrder != null)
            {
                foreach (var order in PendingOrders)
                {
                    if (order.Table == tblId)
                    {
                        var orderItem = order.OrderItems
                            .FirstOrDefault(x => x.Name.Equals(itemName));
                        if (orderItem != null)
                            order.OrderItems.Remove(orderItem);
                    }
                }

                if (tableOrder.OrderItems.Count == 0)
                    RemoveOrder(tblId);
            }

            XmlStateService.SaveOrdersState(PendingOrders);
        }

        public static void RemoveOrder(int tblId)
        {
            var orderToRemove = PendingOrders.FirstOrDefault(x => x.Table == tblId);
            PendingOrders.Remove(orderToRemove);

            XmlStateService.SaveOrdersState(PendingOrders);
        }

        public static void MoveOrder(int fromTable, int toTable)
        {
            var orderToMove = PendingOrders.FirstOrDefault(x => x.Table == fromTable);
            if (orderToMove != null)
            {
                PendingOrders.Remove(orderToMove);

                orderToMove.Table = toTable;
                PendingOrders.Add(orderToMove);

                XmlStateService.SaveOrdersState(PendingOrders);
            }
        }

        public static void FinalizeOrder(int tblId)
        {
            var tableOrder = GetTableOrder(tblId);
            var tableOrderItems = tableOrder.OrderItems;

            int orderCreatedId = S.OrderService.Create(tableOrder);
            foreach (var item in tableOrderItems)
            {
                S.OrderItemService.Create(new OrderItemDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    OrderId = orderCreatedId,
                    Quantity = item.Quantity
                });
            }

            PendingOrders.Remove(tableOrder);
            XmlStateService.SaveOrdersState(PendingOrders);
        }
        #endregion
    }
}
