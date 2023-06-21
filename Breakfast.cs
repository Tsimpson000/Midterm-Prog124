using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Breakfast : Food
    {
        bool _hasDairy;
        public Breakfast(string name, double price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
        {
            _hasDairy = hasDairy;
        }

        public override string ToString()
        {
            return base.ToString() + $" Combo - {_hasDairy}";
        }
    }
}
