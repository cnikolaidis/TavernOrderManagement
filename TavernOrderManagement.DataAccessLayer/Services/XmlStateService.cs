namespace TavernOrderManagement.DataAccessLayer.Services
{
    #region Usings
    using System.Collections.Generic;
    using System.Globalization;
    using Models.Dtos;
    using System.Xml;
    using Utilities;
    #endregion

    public static class XmlStateService
    {
        public static void SaveOrdersState(List<OrderDto> orderList)
        {
            using (var xmlWrt = XmlWriter.Create(@"currentOrders.xml"))
            {
                xmlWrt.WriteStartDocument();
                xmlWrt.WriteStartElement(@"tavernOrders");

                foreach (var order in orderList)
                {
                    xmlWrt.WriteStartElement(@"tableOrder");
                    xmlWrt.WriteAttributeString(@"tableNo", order.Table.ToString());
                    xmlWrt.WriteAttributeString(@"tableSum", order.TotalAmount.ToString("####.00"));

                    foreach (var orderItem in order.OrderItems)
                    {
                        xmlWrt.WriteStartElement(@"tableItem");
                        
                        xmlWrt.WriteAttributeString(@"itemName", orderItem.Name);
                        xmlWrt.WriteAttributeString(@"itemPrice", orderItem.Price.ToString(CultureInfo.InvariantCulture));
                        xmlWrt.WriteAttributeString(@"itemQuantity", orderItem.Quantity.ToString(CultureInfo.InvariantCulture));
                        xmlWrt.WriteString(orderItem.Id.ToString());

                        xmlWrt.WriteEndElement();
                    }
                    xmlWrt.WriteEndElement();
                }
                xmlWrt.WriteEndElement();
                xmlWrt.WriteEndDocument();
            }
        }

        public static List<OrderDto> GetOrdersState()
        {
            var orderList = new List<OrderDto>();

            var ordersDoc = new XmlDocument();
            ordersDoc.Load(@"currentOrders.xml");
            var docElement = ordersDoc.DocumentElement;

            if (docElement == null)
                return orderList;

            foreach (XmlNode order in docElement.ChildNodes)
            {
                if (order.Attributes == null)
                    continue;

                var currentOrder = new OrderDto
                {
                    Table = order.Attributes[@"tableNo"].Value.ToInt(),
                    TotalAmount = order.Attributes[@"tableSum"].Value.ToDecimal(),
                    OrderItems = new List<OrderItemDto>()
                };

                foreach (XmlNode item in order.ChildNodes)
                {
                    if (item.Attributes == null)
                        continue;
                    
                    var itemName = item.Attributes[@"itemName"].Value.TrimStart().TrimEnd();
                    var itemPrice = item.Attributes[@"itemPrice"].Value.TrimStart().TrimEnd().ToDecimal();
                    var itemQuantity = item.Attributes[@"itemQuantity"].Value.TrimStart().TrimEnd().ToDecimal();
                    var itemId = item.InnerText.TrimStart().TrimEnd().ToInt();

                    currentOrder.OrderItems.Add(new OrderItemDto
                    {
                        Id = itemId,
                        Name = itemName,
                        Price = itemPrice,
                        Quantity = itemQuantity
                    });
                }

                orderList.Add(currentOrder);
            }

            return orderList;
        }
    }
}
