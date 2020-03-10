namespace TavernOrderManagement.DataAccessLayer.Models.Dtos
{
    #region Usings
    using System.Collections.Generic;
    #endregion

    public class CategoryCriteriaDto
    {
        public int Id { get; set; }
        public List<int> Ids { get; set; }
        public string Name { get; set; }
    }
}
