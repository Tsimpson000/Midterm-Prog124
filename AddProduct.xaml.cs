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
            PopulateSizeComboBox();
        }

        void PopulateSizeComboBox()
        {
            cbSize.Items.Add("Short");
            cbSize.Items.Add("Tall");
            cbSize.Items.Add("Grande");
            cbSize.Items.Add("Venti");
            cbSize.Items.Add("Trenta");
            cbSize.SelectedIndex = 0;
        }
            private void btnTestProduct_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            double price = rand.Next(1, 11) + rand.NextDouble();
            int point = rand.Next(100, 1001);
            
            Tea tea = new Tea("tea", price, point, (Drink.DrinkSize)rand.Next(0,4));

            Data.AddProductToCollection(tea);
        }

        private void btnTea_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            Drink.DrinkSize drinkSize = (Drink.DrinkSize)cbSize.SelectedIndex;

            Data.AddProductToCollection(new Tea(name, price, points, drinkSize));
        }

        private void btnCoffee_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            Drink.DrinkSize drinkSize = (Drink.DrinkSize)cbSize.SelectedIndex;

            Data.AddProductToCollection(new Coffee(name, price, points, drinkSize));
        }
    }
}
