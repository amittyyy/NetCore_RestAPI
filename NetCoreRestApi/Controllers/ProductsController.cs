using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreRestApi.Data;
using NetCoreRestApi.Models;
using NetCoreRestApi.Services;

namespace NetCoreRestApi.Controllers
{
    //[ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //ProductDbContext productDbContext = new ProductDbContext();

        private IProduct productRepository;
        public ProductsController(IProduct _productRespository)
        {

            productRepository = _productRespository;
        }

        //[HttpGet]

        ////Sorting Implementation
        /////URL:-https://localhost:44315/api/Products?sortPrice=Desc
        //public IEnumerable<Product> Get( string sortPrice)
        //{
        //    IQueryable<Product> products;
        //    switch (sortPrice)
        //    {
        //        case "Desc":
        //            products = productDbContext.Products.OrderByDescending(p => p.ProductPrice);
        //            break;
        //        case "Aesc":
        //            products = productDbContext.Products.OrderBy(p => p.ProductPrice);
        //            break;
        //        default:
        //            products = productDbContext.Products;
        //            break;
        //    }

        //    return products;
        //}

        //[HttpGet]

        ////Paging Implementation
        ////URL:-https://localhost:44315/api/Products?pageNumber=1&pageSize=2
        //public IEnumerable<Product> Get(int? pageNumber, int? pageSize)
        //{
        //    var products = from p in productDbContext.Products.OrderBy(a => a.ProductId) select p;

        //    int currentPage = pageNumber ?? 1;
        //    int currentPageSize = pageSize ?? 5;

        //    var items = products.Skip((currentPage - 1) * currentPageSize).Take(currentPageSize).ToList();


        //    return items;
        //}

        //[HttpGet]

        ////Searching Implementation
        ////URL:-
        //public IEnumerable<Product> Get (string Search)
        //{
        //    var products = productDbContext.Products.Where(p => p.ProductName.StartsWith(Search));
        //    return products;

        //}


        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetProduct();
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = productRepository.GetProduct(id);
            if (product == null)
            {
                return NotFound("No Record Found.....!");
            }

            return Ok(product);
        }



        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            productRepository.AddProduct(product);
            return StatusCode(StatusCodes.Status201Created);            
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (id != product.ProductId)
                return BadRequest();
            try
            {
                productRepository.UpdateProduct(product)
;            }
            catch (Exception)
            {

                return NotFound("No Record Found, Please try Again!!!!!");
            }
           
            return Ok("Product Upadated.....!");
            
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete(int id)
        {
            productRepository.DeleteProduct(id);
            return Ok("Product Deleted.....");
        }
    }
}