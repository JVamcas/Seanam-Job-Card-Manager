using System;
using System.Windows;

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
            MainWindowPanel.Source = new Uri("jobcards/Job Card.xaml", UriKind.RelativeOrAbsolute);
        }

        private void ViewEditJobCard_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindowPanel.Source = new Uri("jobcards/JobCardTable.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}