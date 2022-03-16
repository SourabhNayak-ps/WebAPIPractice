using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using MyWebAppApis.Models;
using MyWebAppApis.Services;

namespace MyWebAppApis.Controllers
{
    [ApiExplorerSettings(IgnoreApi = false)]
    public class ProductsController : Controller
    {
        private readonly IProductRepo productRepo;
        public ProductsController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        //[HttpGet(nameof(ShowAllProducts))]

        [HttpGet]
        [Route("api/products")]
        [EnableQuery]
        public ActionResult<IEnumerable<Product>> ShowAllProducts()
        {
            var products = this.productRepo.GetAllProducts();
            return Ok(products);
        }

        [HttpPost]
        [Route("api/products/add")]
        public ActionResult<Product> AddProducts([FromBody] Product product)
        {
            var products = productRepo.AddProduct(product);
            return Ok(products);
        }

        [HttpPost]
        [Route("api/category/update/")]
        public ActionResult<Product> UpdateCategories(Product product)
        {
            var categories = productRepo.UpdateProducts(product);
            return Ok(categories);
        }

        [HttpGet]
        [Route("api/products/byId/{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product= this.productRepo.GetProductById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("api/products/byName/{name}")]
        public ActionResult<Product> ShowProductByName(string name)
        {
            var product = this.productRepo.GetProductByName(name);
            return Ok(product);
        }

    }
}
