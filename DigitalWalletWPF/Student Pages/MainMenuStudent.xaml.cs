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

namespace DigitalWalletWPF
{
    /// <summary>
    /// Interaction logic for MainMenuStudent.xaml
    /// </summary>
    public partial class MainMenuStudent : Page
    {
        public MainMenuStudent()
        {
            InitializeComponent();
        }

        private void PersonalProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PersonalAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TeamProfiles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StudentProfiles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CurrentWork_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JobAdvertisements_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
