using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;

namespace SeaNam_Job_Card_Controller.ui
{
    public partial class OrderNumberPage
    {
        public OrderNumberPage()
        {
            InitializeComponent();
        }

        public OrderNumberPage(ObservableCollection<OrderNumber> orderNoList,OrderNumber orderNo = null) :this()
        {
            Repo = new OrderRepo();
            Model = orderNo ?? new OrderNumber();
            ModelList = orderNoList ?? new ObservableCollection<OrderNumber>();
            DataContext = Model;
        }
      
        private void SaveOrderNo_OnClick(object sender, RoutedEventArgs e)
        {
            SaveModel();
        }

        private void On_Enter_Key_Up(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            SaveModel();
        }
    }
}