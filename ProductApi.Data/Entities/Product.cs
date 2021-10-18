namespace ProductApi.Data.Entities
{
    /// <summary>
    /// Product entities class
    /// </summary>
    public class Product : BaseEntity
    {
        #region Properties

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string Image { get; set; }

        #endregion
    }
}
