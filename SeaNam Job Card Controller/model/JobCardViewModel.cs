using System;
using System.Collections.ObjectModel;

namespace SeaNam_Job_Card_Controller.model
{
    
    public class JobCardViewModel
    {
        public ObservableCollection<JobCard> JobCardList { get; private set; }
        public JobCardViewModel()
        {
            JobCardList = new ObservableCollection<JobCard>();
            JobCardList.Add(
                new model.JobCard {CreateDate = DateTime.Today, 
                    WorkArea = new WorkArea {Name = "SeaNam"},
                    JobTitle = new JobTitle{TitleValue = "BoilerMaker"},
                    JobCardNo = "JA020"
                }
            );
        }
    }
}