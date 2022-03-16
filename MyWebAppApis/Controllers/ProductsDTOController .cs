using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyWebAppApis.Models.DTOs;
using MyWebAppApis.Services;

namespace MyWebAppApis.Controllers
{
    [ApiController]
    public class ProductsDTOController : Controller
    {
        private readonly IProductRepo productRepo;
        private readonly IMapper mapper;
        public ProductsDTOController(IProductRepo productRepo, IMapper mapper)
        {
            this.productRepo = productRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("api/dtoproducts")]
        public ActionResult<IEnumerable<ProductReadDTO>> ShowAllProducts()
        {
            var products = this.productRepo.GetAllProducts();
            return Ok(this.mapper.Map<IEnumerable<ProductReadDTO>>(products));
        }
    }
}
