using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_643450065_4
{
    public class product
    {
        public string name;
        public double price;
        public void Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public double getPrice()
        { 
            return price; 
        }
    }
}
