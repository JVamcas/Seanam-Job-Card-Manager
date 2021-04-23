using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;

namespace SeaNam_Job_Card_Controller.ui
{
    public partial class WorkAreaPage
    {
        public WorkAreaPage()
        {
            InitializeComponent();
        }

        public WorkAreaPage(ObservableCollection<WorkArea> workAreas,WorkArea workArea = null) :this()
        {
            Repo = new WorkAreaRepo();
            Model = workArea ?? new WorkArea();
            ModelList = workAreas ?? new ObservableCollection<WorkArea>();
            DataContext = Model;
        }
      
        private void SaveWorkArea_OnClick(object sender, RoutedEventArgs e)
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