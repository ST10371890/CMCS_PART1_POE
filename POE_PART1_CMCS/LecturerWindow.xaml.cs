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
using System.Windows.Shapes;

namespace POE_PART1_CMCS
{
    /// <summary>
    /// Interaction logic for LecturerWindow.xaml
    /// </summary>
    public partial class LecturerWindow : Window
    {
        public LecturerWindow()
        {
            InitializeComponent();
        }
        // Submit claim button handler
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic for submitting the claim
            MessageBox.Show("Claim submitted successfully.");
        }

        // Add module button handler
        private void AddModule_Click(object sender, RoutedEventArgs e)
        {
            // Logic to add a new module (add a row to the DataGrid)
            var newModule = new
            {
                ModuleName = "New Module",
                HoursWorked = 0,
                HourlyRate = 0,
                TotalClaim = 0
            };

            var moduleList = new List<object> { newModule };
            dgModules.ItemsSource = moduleList;
        }

        // Upload document button handler
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Logic for uploading a document
            MessageBox.Show("Document uploaded successfully.");
        }
    }
}
