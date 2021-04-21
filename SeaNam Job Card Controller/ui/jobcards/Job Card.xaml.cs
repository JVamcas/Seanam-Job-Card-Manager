using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.ui.jobcards
{
    public partial class JobCard : UserControl
    {
        private model.JobCard _jobCardDetails = new model.JobCard();
        private ObservableCollection<WorkArea> WorkAreaList = new ObservableCollection<WorkArea>();
        private ObservableCollection<JobClass> JobClassList = new ObservableCollection<JobClass>();
        private ObservableCollection<Order> JobCardOrderList = new ObservableCollection<Order>();
        public JobCard()
        {
            InitializeComponent();
            DataContext = _jobCardDetails;
            WorkAreaList.Add(new WorkArea{Name = "Seanam"});
            WorkAreaList.Add(new WorkArea{Name = "NamOps Logistics Pty Ltd"});
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