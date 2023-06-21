using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Food : Product
    {
        protected Food(string name, double price, int points) : base(name, price, points)
        {
        }
    }
}
