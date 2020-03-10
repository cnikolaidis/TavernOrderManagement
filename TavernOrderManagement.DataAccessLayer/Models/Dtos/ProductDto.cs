namespace TavernOrderManagement.DataAccessLayer.Models.Dtos
{
    #region Usings
    using System;
    #endregion

    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool FixedQuantity { get; set; }
        public decimal Price { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
