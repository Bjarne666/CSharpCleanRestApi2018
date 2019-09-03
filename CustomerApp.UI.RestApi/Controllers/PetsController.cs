using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerApp.Core.Entity;
using CustomerApp.Core;
using CustomerApp.Core.ApplicationService;
using CustomerApp.Infrastructure.Static.Data.Repositories;

namespace CustomerApp.UI.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            customerService = _customerService;
        }

        // Get api/pet
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()

        {
            return _customerService.GetAllCustomers();
        }
    }
}