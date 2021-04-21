using System;
using NHibernate;
using SeaNam_Job_Card_Controller.model;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.repo
{
    public class AbstractRepo<T> where T : class

    {
        private ISessionFactory _factory = HibernateUtils.NewInstance();

        public void AddModel(T model)
        {
            using (var session = _factory.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(model);
                    tx.Commit();
                }
                session.Close();
            }
        }
    }
}