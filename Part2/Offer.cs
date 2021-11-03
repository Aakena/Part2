using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2
{
    public class Offer
    {
        public string OfferName { get; set; }

        public List<Product> Products { get; set; }

        public Offer()
        {
            OfferName = "MyOffcer";
            List<Product> prodList = new List<Product>();
        }
    }
}
