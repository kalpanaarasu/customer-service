using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Models
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<Customer> _customerList;

        public MockCustomerRepository()
        {

            _customerList = new List<Customer>()
          {
              new Customer(){CustomerId=1, CustomerName="John", CustomerPhone="889879999",CustomerEmail="z@gmail.com", CustomerAddress=" 1 first main 2nd cross, Bangalore" , CustomerType="x"},
              new Customer(){CustomerId=2, CustomerName="Jack", CustomerPhone="889879999",CustomerEmail="z@gmail.com", CustomerAddress=" 1 first main 2nd cross, Bangalore" ,CustomerType="x"},
              new Customer(){CustomerId = 3, CustomerName = "July", CustomerPhone = "889879999", CustomerEmail = "z@gmail.com", CustomerAddress=" 1 first main 2nd cross, Bangalore" ,CustomerType = "x" }

          };
        }

            public Customer Add(Customer customer)
            {
            customer.CustomerId = _customerList.Max(c => c.CustomerId) + 1;
            _customerList.Add(customer);
            return customer;

            }

            public Customer Delete(int id)
            {
            Customer customer = _customerList.FirstOrDefault(c => c.CustomerId == id);
            if(customer != null)
            {
                _customerList.Remove(customer);
            }
            return customer;
            }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerList;
        }

        public Customer GetCustomer(int Id)
            {
            return _customerList.FirstOrDefault(c => c.CustomerId == Id);

            }

        public Customer Update(Customer customerChanges)
        {
            Customer customer = _customerList.FirstOrDefault(c => c.CustomerId == customerChanges.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customerChanges.CustomerName;
                customer.CustomerPhone = customerChanges.CustomerPhone;
                customer.CustomerEmail = customerChanges.CustomerEmail;
                customer.CustomerAddress = customerChanges.CustomerAddress;
                customer.CustomerType = customerChanges.CustomerType;
                
            }
            return customer;

        }
        }
}
