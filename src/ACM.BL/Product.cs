using System;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public static int InstanceCount { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) return false;
            return isValid;
        }
    }
}
