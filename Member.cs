using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Member
    {
        //fields

        string _firstName;
        string _lastName;
        string _memberNumber;
        int _points;
        DateTime _memberSince = DateTime.Now;
        ObservableCollection<Product> _previousTransactions;
        //constructor
        public Member(string firstName, string lastName)
        {
            Random rand = new Random();
            _firstName = firstName;
            _lastName = lastName;
            _memberNumber = rand.Next(1000000, 10000000).ToString();
            _memberSince = DateTime.Now;
            _points = 0;
            _previousTransactions = new ObservableCollection<Product>();
        }
        //properties
        public ObservableCollection<Product> PreviousTransactions { get => _previousTransactions; }
        protected int Points { get => _points; set => _points = value; }

        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);
        public void AddProduct(Product product)
        {
            _previousTransactions.Add(product);
        }
        public override string ToString()
        {
            return $"{GetType().Name} - {_firstName} {_lastName}. Points: {_points}. Member #: {_memberNumber}";
        }

    }
}
