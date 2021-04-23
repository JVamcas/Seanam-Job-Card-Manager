using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.ui.jobcards
{
    public partial class JobCardTable : Page
    {
        public ObservableCollection<model.JobCard> JobCardList { get; } = new ObservableCollection<model.JobCard>();

        public JobCardTable()
        {
            InitializeComponent();
            JobCardList.Add(
                new model.JobCard {CreateDate = DateTime.Today, 
                    WorkArea = new WorkArea {Name = "SeaNam"},
                    JobCardNo = "JA020",
                    JobDescription = "Repair of a water pump down south of Washington DC."
                }
            );
            JobCardList.Add(
                new model.JobCard {CreateDate = DateTime.Today, 
                    WorkArea = new WorkArea {Name = "SeaNam"},
                    JobCardNo = "JA020",
                    JobDescription = "Repair of a water pump down south of Washington DC."
                }
            );
            DataContext = this;
        }
    }
}