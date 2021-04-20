using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using SeaNam_Job_Card_Controller.Annotations;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.ui;

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
            WorkAreaList.Add(new WorkArea{Name = "Seanam"});
            WorkAreaList.Add(new WorkArea{Name = "NamOps Logistics Pty Ltd"});
            WorkAreaCombo.ItemsSource = WorkAreaList;
            JobClassCombo.ItemsSource = JobClassList;
            
            JobCardOrderList.Add(new Orders{OrderNo = "JA091"});
            JobCardOrderList.Add(new Orders{OrderNo = "JA034"});
            OrdersCombo.ItemsSource = JobCardOrderList;
        }

        private void SaveJobCardBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails.JobClass = JobClassList[(int) JobClassCombo.SelectedItem];
            _jobCardDetails.WorkArea = WorkAreaList[(int) JobClassCombo.SelectedItem];
            _jobCardDetails.OrderList = JobCardOrderList.ToList();

                // persist the jobcard to db    
        }

        private void ClearJobCardForm_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails = new model.JobCard();
            DataContext = _jobCardDetails;
        }

        private void AddWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            WorkAreaPage workAreaPage = new WorkAreaPage();
            workAreaPage.ShowDialog();
        }
    }
}