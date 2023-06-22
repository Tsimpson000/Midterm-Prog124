using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Mugs : Merchandise
    {
        string _design;
        public Mugs(string name, double price, int points, string design) : base(name, price, points)
        {
            _design = design;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Design: {_design}";
        }
    }
}
