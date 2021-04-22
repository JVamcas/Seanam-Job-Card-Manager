using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.ui.jobcards
{
    public partial class JobCard : UserControl
    {
        private model.JobCard _jobCardDetails = new model.JobCard();
        private ObservableCollection<WorkArea> WorkAreaList;
        private ObservableCollection<JobClass> JobClassList = new ObservableCollection<JobClass>();
        private ObservableCollection<Order> JobCardOrderList = new ObservableCollection<Order>();
        private WorkAreaRepo _workAreaRepo = new WorkAreaRepo();
        public JobCard()
        {
            InitializeComponent();
            DataContext = _jobCardDetails;

            WorkAreaList = new ObservableCollection<WorkArea>();
            var workAreas = _workAreaRepo.LoadModels();
            WorkAreaList.AddAll(workAreas);
            
            //
            // WorkAreaList.Add(new WorkArea{Name = "Seanam"});
            // WorkAreaList.Add(new WorkArea{Name = "NamOps Logistics Pty Ltd"});
            WorkAreaCombo.ItemsSource = WorkAreaList;
            JobClassCombo.ItemsSource = JobClassList;
            
            JobCardOrderList.Add(new Order{OrderNo = "JA091"});
            JobCardOrderList.Add(new Order{OrderNo = "JA034"});
            OrdersCombo.ItemsSource = JobCardOrderList;
        }

        private void SaveJobCardBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails.JobClass = JobClassList[(int) JobClassCombo.SelectedItem];
            _jobCardDetails.WorkArea = WorkAreaList[(int) JobClassCombo.SelectedItem];
            _jobCardDetails.OrderList = JobCardOrderList.ToList();
        }

        private void ClearJobCardForm_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails = new model.JobCard();
            DataContext = _jobCardDetails;
        }

        private void AddWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            WorkAreaPage workAreaPage = new WorkAreaPage(WorkAreaList);
            workAreaPage.ShowDialog();
        }

        private void ReLoadData()
        {
            
        }
    }
}