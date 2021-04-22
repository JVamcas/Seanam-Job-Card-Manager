using System;
using System.Collections.ObjectModel;
using System.Windows;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.ui
{
    public partial class WorkAreaPage : AbstractWindow
    {
        private readonly WorkAreaRepo _repo = new WorkAreaRepo();
        private readonly WorkArea _workArea;
        private readonly ObservableCollection<WorkArea> _workAreaList = new ObservableCollection<WorkArea>();

        public WorkAreaPage()
        {
            InitializeComponent();
            _workArea = new WorkArea();
            DataContext = _workArea;
        }

        public WorkAreaPage(WorkArea area) : this()
        {
            _workArea = area;
            DataContext = _workArea;
        }

        public WorkAreaPage(ObservableCollection<WorkArea> workAreas) : this()
        {
            _workAreaList = workAreas;
        }

        private void SaveWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                _repo.AddModel(_workArea);
                RefreshComboListItem();
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }

        private void RefreshComboListItem()
        {
            _workAreaList.Clear();
            var tempArea = _repo.LoadModels();
            _workAreaList.AddAll(tempArea);
        }
    }
}