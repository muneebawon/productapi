using ProductApi.Data.Entities;
using System.Collections.Generic;

namespace ProductApi.Service
{
    /// <summary>
    /// Product service
    /// </summary>
    public partial interface IProductService
    {
        /// <summary>
        /// Get products 
        /// </summary>
        /// <returns>Products</returns>
        ResponseItem<List<Product>> GetProducts();

        /// <summary>
        /// Get product 
        /// </summary>
        /// <returns>Product</returns>
        ResponseItem<Product> GetProduct(Request<BaseEntity> product);
    }
}
