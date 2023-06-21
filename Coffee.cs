using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Coffee : Drink
    {
        public Coffee(string name, double price, int points, DrinkSize size) : base(name, price, points, size)
        {
        }
    }
}
