using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Midterm
{
    internal static class Data
    {
        //fields
        static ObservableCollection<Member> _members;
        static ObservableCollection<Product> _products;

        static Product _currentProduct = null;
        static Member _currentMember = null;

        static Data()
        {
            _members = new ObservableCollection<Member>();
            _products = new ObservableCollection<Product>();
            Preload();
        }

        public static ObservableCollection<Member> Members { get => _members;}
        public static ObservableCollection<Product> Products { get => _products;}
        public static Product CurrentProduct { get => _currentProduct;}
        public static Member CurrentMember { get => _currentMember;}

        public static void AddProductToCollection(Product product)
        {
            _products.Add(product);
        }
        public static void AddMemberToCollection(Member member)
        {
            _members.Add(member);
        }
        public static void UpdateCurrentProduct(Product product)
        {
            _currentProduct = product;
        }
        public static void UpdateCurrentMember(Member member)
        {
            _currentMember = member;
        }
        public static void Preload()
        {
            //preloading member
            _members.Add(new GoldMember("Tyler", "Simpson"));
            _members.Add(new RegularMember("Shiva", "Simpson"));
            
            //preloading products
            _products.Add(new Tea("tea", 5, 100, Drink.DrinkSize.Venti));
            _products.Add(new Coffee("coffee", 6, 200, Drink.DrinkSize.Grande));

            //loading products into members
            _members[0].AddProduct(_products[0]);
            _members[1].AddProduct(_products[1]);
        }
    }
}
