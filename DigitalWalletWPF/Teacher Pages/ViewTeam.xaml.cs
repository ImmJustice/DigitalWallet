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

namespace DigitalWalletWPF.Teacher_Pages
{
    /// <summary>
    /// Interaction logic for ViewTeam.xaml
    /// </summary>
    public partial class ViewTeam : Page
    {
        public ViewTeam()
        {
            InitializeComponent();
        }

        private void SaveTeamAccount_Click(object sender, RoutedEventArgs e)
        {
            ManageTeams manageTeams = new ManageTeams();
            NavigationService.Navigate(manageTeams);

            //Save Team details and add team to list
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ManageTeams manageTeams = new ManageTeams();
            NavigationService.Navigate(manageTeams);
        }

        private void AddFunds_Click(object sender, RoutedEventArgs e)
        {
            TransferFunds transferFunds = new TransferFunds();
            NavigationService.Navigate(transferFunds);
        }
    }
}
