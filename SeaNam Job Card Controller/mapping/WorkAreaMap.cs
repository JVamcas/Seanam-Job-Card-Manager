using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.mapping
{
    public class WorkAreaMap: ClassMap<WorkArea>
    {
        public WorkAreaMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}