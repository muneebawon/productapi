using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Data.Entities;
using ProductApi.Service;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductApi.Controllers
{
    /// <summary>
    /// Product api controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Fields

        private readonly IProductService _productService;

        private readonly ILogger _logger;

        #endregion

        #region Ctor

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;

            _logger = logger;
        }

        #endregion

        #region Methods

        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            ResponseItem<List<Product>> response;
            try
            {
                // Get all products
                response = _productService.GetProducts();

                if (response.IsNull() || !response.Success)
                    return NotFound("No product found.");
            }
            catch(Exception ex)
            {
                _logger.LogError($"Product API Error - {ex.Message}, Stack Trace - {ex.StackTrace}");

                return Problem("Internal Server Error! Pleae contact your system adminstrator.");
            }

            return Ok(response.Result);
        }

        #endregion
    }
}
