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

namespace POE_PART1_CMCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Method to open Lecturer Dashboard
        private void OpenLecturerWindow(object sender, RoutedEventArgs e)
        {
            var lecturerWindow = new LecturerWindow(); // Ensure LecturerWindow is properly defined
            lecturerWindow.Show();
        }

        // Method to open Coordinator Dashboard
        private void OpenCoordinatorWindow(object sender, RoutedEventArgs e)
        {
            var coordinatorWindow = new CoordinatorWindow(); // Ensure CoordinatorWindow is properly defined
            coordinatorWindow.Show();
        }

        // Method to open Claim Status
        private void OpenStatusWindow(object sender, RoutedEventArgs e)
        {
            var statusWindow = new StatusWindow(); // Ensure StatusWindow is properly defined
            statusWindow.Show();
        }
    }
}
