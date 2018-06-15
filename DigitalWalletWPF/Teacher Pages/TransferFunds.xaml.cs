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

namespace DigitalWalletWPF.Teacher_Pages
{
    /// <summary>
    /// Interaction logic for TransferFunds.xaml
    /// </summary>
    public partial class TransferFunds : Page
    {
        public TransferFunds()
        {
            InitializeComponent();
        }

        private void ConfirmTransaction_Click(object sender, RoutedEventArgs e)
        {
            ViewTeam viewTeam = new ViewTeam();
            NavigationService.Navigate(viewTeam);

            //Save Transaction
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ViewTeam viewTeam = new ViewTeam();
            NavigationService.Navigate(viewTeam);
        }
    }
}
