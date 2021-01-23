using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{

   [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public HomeController(ICustomerRepository CustomerRepository)
        {
            _customerRepository = CustomerRepository;
        }
        
        [HttpGet]
        [Route("Index")]
        public JsonResult Index()
        {
            //return Content ("hi");
             var model = _customerRepository.GetAllCustomers();
            return Json(model);
           
        }

        [HttpGet]
        [Route("GetCustomers")]
        public JsonResult GetCustomers()
        {
            var model = _customerRepository.GetAllCustomers();
            return Json(model);
        }

        [HttpGet]
        [Route("GetCustomer")]
        public JsonResult GetCustomer(int Id)
        {
            var model = _customerRepository.GetCustomer(Id);
            return Json(model);
        }


       




    }
}