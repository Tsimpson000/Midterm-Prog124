using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class GiftCard : Product
    {
        double _amount;
        public GiftCard(string name, double price, int points, double amount) : base(name, price, points)
        {
            _amount = amount;
        }
        public override string ToString()
        {
            return base.ToString() + $" Coolor - {_amount}";
        }
    }
}
