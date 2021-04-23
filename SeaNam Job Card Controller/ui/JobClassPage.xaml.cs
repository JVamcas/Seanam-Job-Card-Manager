using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;

namespace SeaNam_Job_Card_Controller.ui
{
    public partial class JobClassPage
    {
        
        public JobClassPage()
        {
            InitializeComponent();
        }
        public JobClassPage(ObservableCollection<JobClass> jobClassList, JobClass jobClass = null) : this()
        {
            Repo = new JobClassRepo();
            Model = jobClass ?? new JobClass();
            ModelList = jobClassList ?? new ObservableCollection<JobClass>();
            DataContext = Model;
        }

        private void On_Enter_Key_Up(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            SaveModel();
        }

        private void SaveJobClass_OnClick(object sender, RoutedEventArgs e)
        {
            SaveModel();
        }
    }
}