using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;

namespace SeaNam_Job_Card_Controller.ui.users
{
    public partial class JobTitleWindow 
    {
        public JobTitleWindow()
        {
            InitializeComponent();
        }
        
        public JobTitleWindow(ObservableCollection<JobTitle> titles, JobTitle jobTitle = null) :this()
        {
            Repo = new JobTitleRepo();
            Model = jobTitle ?? new JobTitle();
            ModelList = titles ?? new ObservableCollection<JobTitle>();
            DataContext = Model;
        }

        private void On_Enter_Key_Up(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            SaveModel();
        }

        private void SaveJobTitle_OnClick(object sender, RoutedEventArgs e)
        {
            SaveModel();
        }
    }
}