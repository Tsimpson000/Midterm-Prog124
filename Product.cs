using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Product
    {
        Random rand = new Random();
        string _name;
        int _sku;
        double _price;
        int _points;
        static int _numberOfProduct;

        public Product(string name, double price, int points)
        {
            _name = name;
            _price = price;
            _points = points;
            _sku = rand.Next(1000000, 10000000);
        }
        public override string ToString()
        {
            return $"{GetType().Name} - {_sku} - {_name} - {_price.ToString("c")} - {_points}";
        }
    }
}
