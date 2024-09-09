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
    /// Interaction logic for StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        public StatusWindow()
        {
            InitializeComponent();
            LoadClaimStatus(); // Load initial claim status into DataGrid
        }
        // Method to populate DataGrid with claim status (replace this with actual data fetching)
        private void LoadClaimStatus()
        {
            var claims = new List<dynamic>
            {
                new { ClaimID = "C001", LecturerName = "Tshepo Gutamo", TotalHours = 20, Status = "Approved" },
                new { ClaimID = "C002", LecturerName = "Nhlakanipho Ndlovu", TotalHours = 18, Status = "Pending" }
            };

            ClaimedStatusDataGrid.ItemsSource = claims;
        }
    }
}
