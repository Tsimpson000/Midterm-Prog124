using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        public AddMember()
        {
            InitializeComponent();

            lbMembers.ItemsSource = Data.Members;
        }

        private void lbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedMember = (Member)lbMembers.SelectedItem;
            Data.UpdateCurrentMember(selectedMember);

            //Attach lisst to items source
            lbPrevTransactions.ItemsSource = Data.CurrentMember.PreviousTransactions;
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            bool goldMembership = rbGold.IsChecked.Value;

            if (goldMembership == true)
            {
                Data.AddMemberToCollection(new GoldMember(firstName, lastName));
            }
            else
            {
                Data.AddMemberToCollection(new RegularMember(firstName, lastName));
            }

        }
    }
}
