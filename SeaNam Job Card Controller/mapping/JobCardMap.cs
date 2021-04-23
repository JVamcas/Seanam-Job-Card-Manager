using FluentNHibernate.Mapping;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.mapping
{
    public class JobCardMap: ClassMap<JobCard>
    {
        public JobCardMap()
        {
            Id(x => x.Id);
            References(x => x.Employee);
            References(x => x.Supervisor);
            References(x => x.JobClass);
            References(x => x.WorkArea);
            Map(x => x.CreateDate);
            Map(x => x.StartTime);
            Map(x => x.EndTime);
            Map(x => x.JobDescription);
            Map(x => x.OtherExplanation);
            Map(x => x.IsNeedReplacement);
            Map(x => x.IsRecurringJob);
            Map(x => x.JobCardNo);
            Map(x => x.IsTimeFrameSatisfactory);
            Map(x => x.IsWorkDoneSatisfactory);
            Map(x => x.IsJobDoneToExpectations);
            HasMany(x => x.OrderList).Cascade.All();

        }
    }
}