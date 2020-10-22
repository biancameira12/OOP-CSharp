using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}