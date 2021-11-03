using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2
{
    public class OfficeService
    {
        private List<Product> Inventory { get; set; }

        private List<Product> GetProductList()
        {
            List<Product> products = new List<Product> {
            new Product{Productname = "P1", Description ="P1 desc", Price = 1000},
                 new Product{Productname = "P2", Description ="P2 desc", Price = 200},
                      new Product{Productname = "P3", Description ="P3 desc", Price = 400},
                           new Product{Productname = "P4", Description ="P4 desc", Price = 700},
                                new Product{Productname = "P5", Description ="P5 desc", Price = 600},
                 new Product{Productname = "P6", Description ="P6 desc", Price = 800},
            };

            return products;
        }

        public OfficeService()
        {
            Inventory = GetProductList();
        }

        public List<Product>  GetAllProducts()
        {
            return Inventory;
        }

        public List<Product> GetTodaysOffers()
        {
            return Inventory;
        }
    }
}
