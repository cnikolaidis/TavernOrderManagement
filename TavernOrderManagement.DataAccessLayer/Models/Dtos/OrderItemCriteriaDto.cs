namespace TavernOrderManagement.DataAccessLayer.Models.Dtos
{
    #region Usings
    using System.Collections.Generic;
    #endregion

    public class OrderItemCriteriaDto
    {
        public int Id { get; set; }
        public List<int> Ids { get; set; }
        public int OrderId { get; set; }
        public List<int> OrderIds { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
