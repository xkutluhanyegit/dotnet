using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
          //TODO: Implement Realistic Implementation
          var data = _customerService.GetAll();
          if (data.Success)
          {
            return Ok(data.Data);
          }
          return BadRequest();
        }
    }
}