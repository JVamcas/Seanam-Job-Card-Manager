using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.ui.jobcards.users
{
    public partial class UsersControl : UserControl
    {
        private Employee _employee = new Employee();
        public UsersControl()
        {
            InitializeComponent();
            DataContext = _employee;
        }

        private void EditJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void DeleteJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

        private void AddJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ClearUserBtn_OnClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}