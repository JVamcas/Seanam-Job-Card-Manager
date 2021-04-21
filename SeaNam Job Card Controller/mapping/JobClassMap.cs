using FluentNHibernate.Mapping;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.mapping
{
    public class JobClassMap: ClassMap<JobClass>
    {
        public JobClassMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.ClassNo);
        }
    }
}