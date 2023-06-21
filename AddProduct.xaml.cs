using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
            lbProduct.ItemsSource = Data.Products;
        }

        private void btnTestProduct_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            double price = rand.Next(1, 11) + rand.NextDouble();
            int point = rand.Next(100, 1001);
            
            Tea tea = new Tea("tea", price, point, (Drink.DrinkSize)rand.Next(0,4));

            Data.AddProductToCollection(tea);
        }
    }
}
