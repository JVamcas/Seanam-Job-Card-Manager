using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.ui
{
    public partial class WorkAreaPage : AbstractWindow
    {
        private readonly WorkAreaRepo _repo = new WorkAreaRepo();
        private readonly WorkArea _workArea = new WorkArea();
        private readonly ObservableCollection<WorkArea> _workAreaList = new ObservableCollection<WorkArea>();

        public WorkAreaPage()
        {
            InitializeComponent();
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
                _workAreaList.Clear();
                var tempAreas = _repo.LoadModels();
                _workAreaList.AddAll(tempAreas);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}