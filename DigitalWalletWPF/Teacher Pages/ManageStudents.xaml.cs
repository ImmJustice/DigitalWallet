﻿using System;
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
    /// Interaction logic for ManageStudents.xaml
    /// </summary>
    public partial class ManageStudents : Page
    {
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void CreateNewStudent_Click(object sender, RoutedEventArgs e)
        {
            CreateNewStudent createNewStudent = new CreateNewStudent();
            NavigationService.Navigate(createNewStudent);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainMenuTeacher mmt = new MainMenuTeacher();
            NavigationService.Navigate(mmt);
        }
    }
}
