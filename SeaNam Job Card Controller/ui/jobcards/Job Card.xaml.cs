using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FluentNHibernate.Conventions;
using MaterialDesignThemes.Wpf;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.ui.jobcards
{
    public partial class JobCard : UserControl
    {
        private model.JobCard _jobCardDetails = new model.JobCard();
        private ObservableCollection<WorkArea> WorkAreaList;
        private ObservableCollection<JobClass> JobClassList;
        private ObservableCollection<OrderNumber> JobCardOrderList;
        private WorkAreaRepo _workAreaRepo = new WorkAreaRepo();
        private JobClassRepo _classRepo = new JobClassRepo();
        private OrderRepo _orderRepo = new OrderRepo();

        public JobCard()
        {
            InitializeComponent();
            DataContext = _jobCardDetails;

            WorkAreaList = new ObservableCollection<WorkArea>();
            var workAreas = _workAreaRepo.LoadModels();
            WorkAreaList.AddAll(workAreas);

            JobClassList = new ObservableCollection<JobClass>();
            var jobClassList = _classRepo.LoadModels();
            JobClassList.AddAll(jobClassList);

            JobCardOrderList = new ObservableCollection<OrderNumber>();
            var orders = _orderRepo.LoadOrders(_jobCardDetails.Id);
            JobCardOrderList.AddAll(orders);

            WorkAreaCombo.ItemsSource = WorkAreaList;
            JobClassCombo.ItemsSource = JobClassList;
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
            var areaPage = new WorkAreaPage(WorkAreaList);
            areaPage.ShowDialog();
        }

        private void EditWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            var area = (WorkArea)WorkAreaCombo.SelectedItem;
            new WorkAreaPage(area).ShowDialog();
            
        }

        private void DeleteWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            var area = (WorkArea) WorkAreaCombo.SelectedItem;
            _workAreaRepo.DeleteModel(area);
            WorkAreaList.Clear();
            WorkAreaList.AddAll(_workAreaRepo.LoadModels());
        }
    }
}