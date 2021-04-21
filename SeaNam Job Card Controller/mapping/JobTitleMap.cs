using FluentNHibernate.Mapping;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.mapping
{
    public class JobTitleMap: ClassMap<JobTitle>
    {
        public JobTitleMap()
        {
            Id(x => x.Id);
            Map(x => x.TitleValue);
        }
    }
}