using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Tea : Drink
    {
        public Tea(string name, double price, int points, DrinkSize size) : base(name, price, points, size)
        {
        }

    }
}
