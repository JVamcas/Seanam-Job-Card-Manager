using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.Annotations;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.jobcards
{
    public partial class JobCard : UserControl
    {
        private model.JobCard _jobCardDetails = new model.JobCard();
        private ObservableCollection<WorkArea> WorkAreaList = new ObservableCollection<WorkArea>();
        private ObservableCollection<JobClass> JobClassList = new ObservableCollection<JobClass>();
        private ObservableCollection<Orders> JobCardOrderList = new ObservableCollection<Orders>();
        public JobCard()
        {
            InitializeComponent();
            DataContext = _jobCardDetails;
            WorkAreaList.Add(new WorkArea(){Name = "Seanam"});
            WorkAreaList.Add(new WorkArea(){Name = "NamOps Logistics Pty Ltd"});
            WorkAreaCombo.ItemsSource = WorkAreaList;
            WorkClassCombo.ItemsSource = JobClassList;
            
            JobCardOrderList.Add(new Orders(){OrderNo = "JA091"});
            JobCardOrderList.Add(new Orders(){OrderNo = "JA034"});
            OrdersCombo.ItemsSource = JobCardOrderList;
        }

        private void SaveJobCardBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(_jobCardDetails.JobDescription);
        }

        private void ClearJobCardForm_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails = new model.JobCard();
            DataContext = _jobCardDetails;
        }
    }
}