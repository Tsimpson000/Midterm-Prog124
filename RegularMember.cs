using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class RegularMember : Member
    {
        public RegularMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void AddPoints(Product product)
        {
            Points += product.Points;
        }

        public override void DeductPoints(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
