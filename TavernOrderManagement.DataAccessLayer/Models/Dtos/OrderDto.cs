namespace TavernOrderManagement.DataAccessLayer.Models.Dtos
{
    #region Usings
    using System.Collections.Generic;
    using System;
    #endregion

    public class OrderDto
    {
        public int Id { get; set; }
        public int Table { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}
