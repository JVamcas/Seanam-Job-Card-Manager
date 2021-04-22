using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Classic;
using SeaNam_Job_Card_Controller.Utils;

namespace SeaNam_Job_Card_Controller.repo
{
    public class AbstractRepo<T> where T : class

    {
        private readonly ISessionFactory _factory = HibernateUtils.NewInstance();

        public void AddModel(T model)
        {
            ISession session = null;
            try
            {
                session = _factory.OpenSession();
                var tx = session.BeginTransaction();
                session.SaveOrUpdate(model);
                tx.Commit();
            }
            finally
            {
                session?.Close();
            }
        }

        public void DeleteModel(T model)
        {
        }

        public IList<T> LoadModels()
        {
            IList<T> models = new List<T>();
            ISession session = null;
            try
            {
                session = _factory.OpenSession();
                models = session.CreateCriteria<T>().List<T>();
                return models;
            }
            finally
            {
                session?.Close();
            }
        }
    }
}