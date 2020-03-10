namespace TavernOrderManagement.DataAccessLayer.Models.Dtos
{
    #region Usings
    using System.Collections.Generic;
    using System;
    #endregion

    public class OrderCriteriaDto
    {
        public int Id { get; set; }
        public List<int> Ids { get; set; }
        public int Table { get; set; }
        public List<int> Tables { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
