//Tyler Simpson
//June 21 2023
//Prog 124 Midterm

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

        private void btnBuyProduct_Click(object sender, RoutedEventArgs e)
        {
            if(Data.CurrentProduct != null & Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct);
                Data.CurrentMember.AddPoints(Data.CurrentProduct);
                cbMembers.Items.Refresh();
            }
        }

        private void lbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product currentlySelected = (Product)lbProducts.SelectedItem;
            Data.UpdateCurrentProduct(currentlySelected);
        }

        private void btnUsePoints_Click(object sender, RoutedEventArgs e)
        {
            if (Data.CurrentProduct != null & Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct);
                Data.CurrentMember.DeductPoints(Data.CurrentProduct);
                cbMembers.Items.Refresh();
            }
        }
    }
}
