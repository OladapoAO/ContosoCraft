using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Website.Models;
using ContosoCrafts.Website.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoCrafts.Website.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private  IJsonFileProductService _productService { get; }

        public ProductsController(IJsonFileProductService productService)
        {
            _productService = productService;
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery]string ProductId,
            [FromQuery]int Rating)
        {
            _productService.AddRating(ProductId, Rating);

            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

