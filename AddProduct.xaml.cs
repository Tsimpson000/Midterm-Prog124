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
using static Midterm.Drink;

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

        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            bool isHeated = ckHeated.IsChecked.Value;
            bool hasDairy = ckDairyCombo.IsChecked.Value;

            Data.AddProductToCollection(new Breakfast(name, price, points, isHeated, hasDairy));
        }

        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);

            bool isHeated = ckHeated.IsChecked.Value;
            bool isCombo = ckDairyCombo.IsChecked.Value;

            Data.AddProductToCollection(new Lunch(name, price, points, isHeated, isCombo));
        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            string color = txtColorStyle.Text;

            Data.AddProductToCollection(new Tumblers(name, price, points, color));
        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            string style = txtColorStyle.Text;

            Data.AddProductToCollection(new Mugs(name, price, points, style));
        }

        private void btnGiftCard_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            double amount = double.Parse(txtPrice.Text);

            Data.AddProductToCollection(new GiftCard(name, price, points, amount));
        }
    }
}
