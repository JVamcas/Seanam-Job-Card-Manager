using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public class JobCard : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string JobCardNo { get; set; }
        public JobTitle JobTitle { get; set; } // the title for this job not employee job title
        public string JobDescription { get; set; }
        public WorkArea WorkArea { get; set; }
        public JobClass JobClass { get; set; }
        public List<Orders> OrderList { get; set; }
        public User Employee { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean IsWorkDoneSatisfactory { get; set; } = false;
        public Boolean IsNeedReplacement { get; set; } = false;
        public Boolean IsRecurringJob { get; set; } = false;
        public Boolean IsTimeFrameSatisfactory { get; set; } = false;
        public Boolean IsJobDoneToExpectations { get; set; } = false;
        public string OtherExplanation { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}