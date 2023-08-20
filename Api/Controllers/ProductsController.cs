using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult getall()
        {
          var result = _productService.GetAll();
          return Ok(result);
        }


        [HttpPost("add")]
        public IActionResult add(Products products)
        {
          _productService.Add(products);
          return Ok();
        }


        
    }
}