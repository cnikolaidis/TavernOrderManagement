namespace TavernOrderManagement.DataAccessLayer.Models.Dtos
{
    #region Usings
    using System.Collections.Generic;
    using System;
    #endregion

    public class ProductCriteriaDto
    {
        public int Id { get; set; }
        public List<int> Ids { get; set; }
        public string Name { get; set; }
        public string NameContains { get; set; }
        public string Category { get; set; }
        public bool? FixedQuantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
