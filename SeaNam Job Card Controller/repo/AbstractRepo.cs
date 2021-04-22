using System;
using System.Collections.Generic;
using NHibernate;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.repo
{
    public class AbstractRepo<T> where T : class

    {
        protected readonly ISessionFactory _factory = HibernateUtils.NewInstance();

        public void AddModel(T model)
        {
            ISession session = null;
            try
            {
                session = _factory.OpenSession();
                var tx = session?.BeginTransaction();
                session?.SaveOrUpdate(model);
                tx?.Commit();
            }
            finally
            {
                session?.Close();
            }
        }

        public void DeleteModel(T model)
        {
            ISession session = null;
            try
            {
                session = _factory.OpenSession();
                var tx = session?.BeginTransaction();
                session?.Delete(model);
                tx?.Commit();
            }
            finally
            {
                session?.Close();
            }
        }

        public IList<T> LoadModels()
        {
            ISession session = null;
            try
            {
                session = _factory.OpenSession();
                IList<T> models = session.CreateCriteria<T>().List<T>();
                return models;
            }
            finally
            {
                session?.Close();
            }
        }
    }
}