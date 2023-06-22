using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Tumblers : Merchandise
    {
        string _color;
        public Tumblers(string name, double price, int points, string color) : base(name, price, points)
        {
            _color = color;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Color: {_color}";
        }
    }
}
