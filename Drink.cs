using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Drink : Product
    {
        //fields
        public enum DrinkSize {Short, Tall, Grande, Venti, Trenta}
        DrinkSize _size;

        //constructor
        protected Drink(string name, double price, int points, DrinkSize size) : base(name, price, points)
        {
            _size = size;
        }
        public override string ToString()
        {
            return base.ToString() + $" - Size: {_size}";
        }
    }
}
