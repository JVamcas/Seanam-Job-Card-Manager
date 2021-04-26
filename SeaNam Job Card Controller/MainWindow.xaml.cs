using System;
using System.Windows;
using System.Windows.Input;

namespace SeaNam_Job_Card_Controller
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

        private void NewJobCard_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindowPanel.Source = new Uri("ui/jobcards/Job Card.xaml", UriKind.RelativeOrAbsolute);
        }

        private void ViewEditJobCard_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindowPanel.Source = new Uri("ui/jobcards/JobCardTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void UserTab_OnClick(object sender, MouseButtonEventArgs e)
        {
            UserWindowPanel.Source = new Uri("ui/jobcards/users/UsersControl.xaml",UriKind.RelativeOrAbsolute);
        }
    }
}