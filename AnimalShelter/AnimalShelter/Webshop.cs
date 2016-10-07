using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Webshop
    {
        public List<Product> producten = new List<Product>();

        public bool AddProduct(string name, decimal price)
        {
            producten.Add(new Product(name, price));
            return true;
        }
    }
}
