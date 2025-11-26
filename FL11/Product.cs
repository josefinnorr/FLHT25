using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FL11
{
    internal class Product
    {
        int _countPriceChanges = 0;

        public string Name { get; set; }
        public string Country { get; set; }
        public bool Organic { get; set; }

        public double Price { get; set; }
        public double Weight { get; set; }

        public Product(string name)
        {
           // name liten bokstav --> indataparameter
           // Name stor bokstav --> property/egenskap
            Name = name;
        }

        // Metod

        public void SetPrice(double price)
        {
            
            if (price <= 0)
            {
                return;
            }

            if(_countPriceChanges > 1)
            {
                return;
            }
            
            _countPriceChanges++;
            Price = price;

        }
    }
}
