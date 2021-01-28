using CustomerService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository repository)
        {
            _customerRepository = repository;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _customerRepository.GetCustomer(id);

            if (customer == null)
                return NotFound();

            return customer;
        }

        [HttpGet("customers")]

        public IEnumerable<Customer> GelAllCustomerDetails()
        {
            return _customerRepository.GetAllCustomers().ToArray();


        }



        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Customer customer)
        {

            if (customer == null)
            {
                return NotFound("customer data not supplied");

            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _customerRepository.Add(customer);
            return Ok(customer);
        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Customer customerChanges)
        {

            if (customerChanges == null)
            {
                return NotFound("customer data not supplied");

            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _customerRepository.Update(customerChanges);

            return Ok(customerChanges);

        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int Id)
        {
            var customer = _customerRepository.Delete(Id);

            if (customer == null)
            {
                return NotFound("Not deleted");
            }
            else
            {
                return Ok(customer);
            }

        }

        [HttpGet("search/{customerName}")]
          
        public ActionResult<List<Customer>> SearchByName(string customerName)
        {
         
           if (customerName == null)
           {
                return NotFound("Name value is not supplied");
           }
            var customerList = _customerRepository.GetAllCustomers().ToList();
                                
            var customersByName= customerList.Where(cust => cust.CustomerName == customerName).ToList();
            
         return Ok(customersByName);
        }

    }


    
}
