using System;
using System.Windows;
using System.Windows.Controls;

namespace SeaNam_Job_Card_Controller.jobcards
{
    public partial class JobCard : UserControl
    {
        public model.JobCard JobCardDetails = new model.JobCard();
        public JobCard()
        {
            InitializeComponent();
            DataContext = JobCardDetails;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(JobCardDetails.JobDescription);
        }

        private void Button_OnClick1(object sender, RoutedEventArgs e)
        {
            JobCardDetails = new model.JobCard();
            DataContext = JobCardDetails;
        }
    }
}