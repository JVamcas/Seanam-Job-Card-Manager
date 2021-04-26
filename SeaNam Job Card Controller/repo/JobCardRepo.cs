using System;
using System.Collections.Generic;
using NHibernate;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.repo
{
    public class JobCardRepo : AbstractRepo<JobCard>
    {
        private ISessionFactory _factory = HibernateUtils.NewInstance();
        

        public void UpdateJobCard(JobCard jobCard)
        {
            
        }

        public JobCard FindJobCard(string JobCardId)
        {
            return null;
        }

        public List<JobCard> FindJobCard(DateTime startDate, DateTime endDate) 
        {
            return null;
        }

        // public override void AddModel(JobCard model)
        // {
        //     base.AddModel(model);
        //     var orderRepo = new OrderRepo();
        //     foreach (var order in model.OrderList)
        //     {
        //         order.
        //     }
        // }
    }
}