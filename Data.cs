﻿using System;
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
    }
}
