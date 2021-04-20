using NHibernate;
using NHibernate.Cfg;

namespace SeaNam_Job_Card_Controller.Utils
{
    public class HibernateUtils
    {
        private static ISessionFactory _sessionFactory;
        private static readonly object _lock = new object();

        private HibernateUtils()
        {
        }
        
        public static ISessionFactory NewInstance()
        {
            if (_sessionFactory == null)
            {
                lock (_lock)
                {
                    Configuration nhConfig = new Configuration().Configure();
                    _sessionFactory = nhConfig.BuildSessionFactory();
                }
            }
            return _sessionFactory;
        }
    }
}