using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Part2
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdctsController : ControllerBase
    {
        readonly private OfficeService _officeService;

        public ProdctsController(OfficeService officeService)
        {
            _officeService = officeService;

            
        }
        [HttpGet]
        public List<Product> getAllProducts()
        {
            List<Product> products = new List<Product>();
            products = _officeService.GetAllProducts();


            return products.
        }
    }
}
