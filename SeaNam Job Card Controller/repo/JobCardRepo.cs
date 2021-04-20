using System;
using System.Collections.Generic;
using NHibernate;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.repo
{
    public class JobCardRepo
    {
        private ISessionFactory _factory = HibernateUtils.NewInstance();

        public void AddJobCard(JobCard jobCard)
        {
            using (var session = _factory.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.CreateCriteria<JobCard>();
                    tx.Commit();
                }
                session.Close();
            }
        }

        public void UpdateJobCard(JobCard jobCard)
        {
            
        }

        public void DeleteJobCard(JobCard jobCard)
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
    }
}