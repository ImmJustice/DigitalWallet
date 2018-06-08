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
using DigitalWalletWPF.Teacher_Pages;

namespace DigitalWalletWPF
{
    /// <summary>
    /// Interaction logic for MainMenuTeacher.xaml
    /// </summary>
    public partial class MainMenuTeacher : Page
    {
        public MainMenuTeacher()
        {
            InitializeComponent();
        }

        private void ManageStudents_Click(object sender, RoutedEventArgs e)
        {
            ManageStudents manageStudents = new ManageStudents();
            NavigationService.Navigate(manageStudents);
        }

        private void ManageTeams_Click(object sender, RoutedEventArgs e)
        {
            ManageTeams manageTeams = new ManageTeams();
            NavigationService.Navigate(manageTeams);
        }

        private void TransferMoney_Click(object sender, RoutedEventArgs e)
        {
            TransferFunds transferFunds = new TransferFunds();
            NavigationService.Navigate(transferFunds);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
