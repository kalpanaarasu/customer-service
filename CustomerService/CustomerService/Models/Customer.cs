using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class Customer
    {
       
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Name can not exceed 50 characters")]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage = "Phone Number can not exceed 10 Numbers")]
        public string CustomerPhone { get; set; }
        [Required]
        [RegularExpression(@"^[a - zA - Z0 - 9_.-] +)@([a - zA - Z] +)([\.])([a - zA - Z]+)",ErrorMessage ="Invalid Email Format")]
        
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(100,ErrorMessage ="Address can not exceed 100 characters")]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Type of Customer can not exceed 10 characters")]
        public string CustomerType { get; set; }


    }
}
