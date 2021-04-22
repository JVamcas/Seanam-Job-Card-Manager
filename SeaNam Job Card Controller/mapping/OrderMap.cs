using FluentNHibernate.Mapping;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.mapping
{
    public class OrderNumberMap: ClassMap<OrderNumber>
    {
        public OrderNumberMap()
        {
            Id(x => x.Id);
            Map(x => x.OrderNo);
        }
    }
}