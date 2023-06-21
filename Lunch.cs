using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Lunch : Food
    {
        bool _isCombo;
        public Lunch(string name, double price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            _isCombo = isCombo;
        }

        public override string ToString()
        {
            return base.ToString() + $" Combo - {_isCombo}";
        }
    }
}
