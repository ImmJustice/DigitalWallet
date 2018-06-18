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
    /// Interaction logic for ManageTeams.xaml
    /// </summary>
    public partial class ManageTeams : Page
    {
        public ManageTeams()
        {
            InitializeComponent();
        }

        private void CreateNewTeam_Click(object sender, RoutedEventArgs e)
        {
            CreateNewTeam createNewTeam = new CreateNewTeam();
            NavigationService.Navigate(createNewTeam);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainMenuTeacher mainMenuTeacher = new MainMenuTeacher();
            NavigationService.Navigate(mainMenuTeacher);
        }

        private void ViewTeam_Click(object sender, RoutedEventArgs e)
        {
            ViewTeam viewTeam = new ViewTeam();
            NavigationService.Navigate(viewTeam);
        }
    }
}
