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
        private ObservableCollection<JobClass> JobClassList;
        private ObservableCollection<OrderNumber> OrderNoList;
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

            OrderNoList = new ObservableCollection<OrderNumber>();
            var orders = _orderRepo.LoadOrders(_jobCardDetails.Id);
            OrderNoList.AddAll(orders);

            WorkAreaCombo.ItemsSource = WorkAreaList;
            JobClassCombo.ItemsSource = JobClassList;
            OrdersCombo.ItemsSource = OrderNoList;
        }

        private void SaveJobCardBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails.JobClass = JobClassList[(int) JobClassCombo.SelectedItem];
            _jobCardDetails.WorkArea = WorkAreaList[(int) JobClassCombo.SelectedItem];
            _jobCardDetails.OrderList = OrderNoList.ToList();
        }

        private void ClearJobCardForm_OnClick(object sender, RoutedEventArgs e)
        {
            _jobCardDetails = new model.JobCard();
            DataContext = _jobCardDetails;
        }

        private void AddWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            var areaPage = new WorkAreaPage(WorkAreaList, new WorkArea());
            areaPage.ShowDialog();
        }

        private void EditWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            var area = (WorkArea) WorkAreaCombo.SelectedItem;
            if (area == null) return;
            new WorkAreaPage(WorkAreaList, area).ShowDialog();
            WorkAreaCombo.SelectedItem = area;
        }

        private void DeleteWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            var area = (WorkArea) WorkAreaCombo.SelectedItem;
            if (area == null) return;
            _workAreaRepo.DeleteModel(area);
            WorkAreaList.Clear();
            WorkAreaList.AddAll(_workAreaRepo.LoadModels());
        }

        private void AddJobClass_OnClick(object sender, RoutedEventArgs e)
        {
            var areaPage = new JobClassPage(JobClassList, new JobClass());
            areaPage.ShowDialog();
        }

        private void EditJobClass_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(JobClassCombo.SelectedItem is JobClass area)) return;
            new JobClassPage(JobClassList, area).ShowDialog();
            JobClassCombo.SelectedItem = area;
        }

        private void DeleteJobClass_OnClick(object sender, RoutedEventArgs e)
        {
            if(!(JobClassCombo.SelectedItem is JobClass area)) return;
            _classRepo.DeleteModel(area);
            JobClassList.Clear();
            JobClassList.AddAll(_classRepo.LoadModels());
        }
        
        private void AddOrderNo_OnClick(object sender, RoutedEventArgs e)
        {
            var areaPage = new OrderNumberPage(OrderNoList, new OrderNumber());
            areaPage.ShowDialog();
        }

        private void EditOrderNo_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(OrdersCombo.SelectedItem is OrderNumber area)) return;
            new OrderNumberPage(OrderNoList, area).ShowDialog();
            OrdersCombo.SelectedItem = area;
        }

        private void DeleteOrderNo_OnClick(object sender, RoutedEventArgs e)
        {
            if(!(OrdersCombo.SelectedItem is OrderNumber area)) return;
            _orderRepo.DeleteModel(area);
            OrderNoList.Clear();
            OrderNoList.AddAll(_orderRepo.LoadModels());
        }
    }
}