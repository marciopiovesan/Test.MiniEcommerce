﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Ecommerce.Customers.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String CPF { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public string Address { get; set; }
    }
}
