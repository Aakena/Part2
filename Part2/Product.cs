﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2
{
    public class Product
    {
        public string Productname { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }

        public Product()
        {
            Productname = "MyProduct";
            Price = 20;
            Description = "TestDesc";
        }
    }
}
