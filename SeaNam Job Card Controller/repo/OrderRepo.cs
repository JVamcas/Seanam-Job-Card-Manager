using System;
using System.Collections.Generic;
using NHibernate;
using SeaNam_Job_Card_Controller.model;

namespace SeaNam_Job_Card_Controller.repo
{
    public class OrderRepo: AbstractRepo<OrderNumber>
    {
        public IList<OrderNumber> LoadOrders(int jobCardId)
        {
            try
            {
                ISession session = null;
                try
                {
                    session = _factory.OpenSession();
                    var models = session.CreateSQLQuery("Select * from ordernumbers o where o.JobCard_id=:jobCardId")
                        .AddEntity("order",typeof(OrderNumber))
                        .SetParameter("jobCardId",jobCardId)
                        .List<OrderNumber>();
                    return models;
                }
                finally
                {
                    session?.Close();
                }
            }
            finally{
            {
                
            }}
        }
    }
}