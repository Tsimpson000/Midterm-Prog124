﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Drink : Product
    {
        protected Drink(string name, double price, int points) : base(name, price, points)
        {
        }
    }
}
