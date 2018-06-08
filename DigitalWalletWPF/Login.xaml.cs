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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //Clear boxes


            //Temp Code to Login as a Teacher or a Student
            if (username.Text == "student" && password.Text == "student")
            {
                MainMenuStudent mainMenuStudent = new MainMenuStudent();
                NavigationService.Navigate(mainMenuStudent);
            }
            if (username.Text == "teacher" && password.Text == "teacher")
            {
                MainMenuTeacher mainMenuTeacher = new MainMenuTeacher();
                NavigationService.Navigate(mainMenuTeacher);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
