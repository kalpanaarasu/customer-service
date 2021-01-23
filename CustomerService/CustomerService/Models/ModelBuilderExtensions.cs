using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerName = "Ashwin", CustomerPhone = "999999999", CustomerEmail = "Ashwin@gmail.com", CustomerAddress = "303, bm shomaparadise", CustomerType = "Gold" },
                new Customer { CustomerId = 2, CustomerName = "Bhuvan", CustomerPhone = "999999999", CustomerEmail = "Ashwin@gmail.com", CustomerAddress = "303, bm shomaparadise", CustomerType = "Gold" }
            );
        }
    }
}
