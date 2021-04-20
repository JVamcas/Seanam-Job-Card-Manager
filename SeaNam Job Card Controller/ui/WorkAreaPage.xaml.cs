using System;
using System.Windows;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.repo;

namespace SeaNam_Job_Card_Controller.ui
{
    public partial class WorkAreaPage : Window
    {
        private readonly WorkAreaRepo repo = new WorkAreaRepo();
        private WorkArea _workArea = new WorkArea();
        public WorkAreaPage()
        {
            InitializeComponent();
            DataContext = _workArea;
        }

        private void SaveWorkArea_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                repo.AddModel(_workArea);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}