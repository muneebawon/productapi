using ProductApi.Data;
using ProductApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductApi.Service
{
    public class ProductService : IProductService
    {
        #region Fields

        private readonly IProductRepository _productRepository;

        #endregion

        #region Ctor

        public ProductService(IProductRepository repository)
        {
            _productRepository = repository;
        }

        #endregion

        #region Methods

        public ResponseItem<List<Product>> GetProducts()
        {
            var response = new ResponseItem<List<Product>>()
            {
                Result = _productRepository.Table.OrderBy(p => p.Id).ToList()
            };

            response.Success = response.Result.IsNotNull() && response.Result.Count > 0;

            return response;
        }

        public ResponseItem<Product> GetProduct(Request<BaseEntity> product)
        {
            var response = new ResponseItem<Product>() { Success = false };

            if (product.IsNotNull() && product.Entity.IsNotNull() && product.Entity.Id > 0)
            {
                response.Result = _productRepository.Table.Where(p => p.Id == product.Entity.Id).FirstOrDefault();
            }

            response.Success = response.Result.IsNotNull();

            return response;
        }

        #endregion
    }
}
