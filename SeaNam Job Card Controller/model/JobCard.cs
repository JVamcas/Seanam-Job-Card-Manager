using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NHibernate.Criterion;
using SeaNam_Job_Card_Controller.Annotations;

namespace SeaNam_Job_Card_Controller.model
{
    public  class JobCard : INotifyPropertyChanged
    {
        public virtual int Id { get; protected set; }
        public virtual string JobCardNo { get; set; }
        public virtual JobTitle JobTitle { get; set; } // the title for this job not employee job title
        public virtual string JobDescription { get; set; }
        public virtual WorkArea WorkArea { get; set; }
        public virtual JobClass JobClass { get; set; }
        public virtual IList<OrderNumber> OrderList { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual Boolean IsWorkDoneSatisfactory { get; set; } = false;
        public virtual Boolean IsNeedReplacement { get; set; } = false;
        public virtual Boolean IsRecurringJob { get; set; } = false;
        public virtual Boolean IsTimeFrameSatisfactory { get; set; } = false;
        public virtual Boolean IsJobDoneToExpectations { get; set; } = false;
        public virtual string OtherExplanation { get; set; }
        public virtual Employee Supervisor { get; set; }

        public JobCard()
        {
            OrderList = new List<OrderNumber>();
        }
        
        public virtual event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}