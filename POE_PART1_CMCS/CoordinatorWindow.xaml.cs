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
    /// Interaction logic for CoordinatorWindow.xaml
    /// </summary>
    public partial class CoordinatorWindow : Window
    {
        public CoordinatorWindow()
        {
            InitializeComponent();
            LoadPendingClaims(); // Load initial claims into DataGrid
        }
        // Method to populate DataGrid with pending claims (you can replace this with actual data fetching)
        private void LoadPendingClaims()
        {
            var pendingClaims = new List<dynamic>
            {
                new { ClaimID = "C001", LecturerName = "Tshepo Gutamo", TotalHours = 20, Status = "Pending" },
                new { ClaimID = "C002", LecturerName = "Nhlakanipho Ndlovu", TotalHours = 18, Status = "Pending" }
            };

            dgPendingClaims.ItemsSource = pendingClaims;
        }

        // Approve Claim button handler
        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            var selectedClaim = dgPendingClaims.SelectedItem;
            if (selectedClaim != null)
            {
                // Logic for approving the claim
                MessageBox.Show("Claim Approved!");

                // You can implement more actions here, like updating the status or notifying the lecturer ( A reminder for part 2)
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.");
            }
        }

        // Reject Claim button handler
        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            var selectedClaim = dgPendingClaims.SelectedItem;
            if (selectedClaim != null)
            {
                // Logic for rejecting the claim
                MessageBox.Show("Claim Rejected.");
                // You can implement more actions here, like updating the status or sending rejection feedback
            }
            else
            {
                MessageBox.Show("Please select a claim to reject.");
            }
        }
    }
}
