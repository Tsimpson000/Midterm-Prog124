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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GoldMember rg = new GoldMember("Tyler", "Simpson");

           
            lbProducts.ItemsSource = Data.Products;
            cbMembers.ItemsSource = Data.Members;
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            new AddProduct().Show();
        } //btnAddProduct_Click

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            new AddMember().Show();
        }

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedMember = (Member)cbMembers.SelectedItem;
            Data.UpdateCurrentMember(selectedMember);

            //Attach lisst to items source
            lbPrevTransactions.ItemsSource = Data.CurrentMember.PreviousTransactions;
        }
    }
}
