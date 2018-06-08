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
    /// Interaction logic for CreateNewStudent.xaml
    /// </summary>
    public partial class CreateNewStudent : Page
    {
        public CreateNewStudent()
        {
            InitializeComponent();
        }

        private void SaveAccount_Click(object sender, RoutedEventArgs e)
        {
            ManageStudents manageStudents = new ManageStudents();
            NavigationService.Navigate(manageStudents);

            //Save Account as New Student
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            ManageStudents manageStudents = new ManageStudents();
            NavigationService.Navigate(manageStudents);

            //Cancel Creation of New Student
        }
    }
}
