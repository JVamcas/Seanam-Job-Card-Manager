using System;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Util;
using SeaNam_Job_Card_Controller.mapping;
using SeaNam_Job_Card_Controller.model;

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
                    _sessionFactory = Fluently
                        .Configure()
                        .Database(MySQLConfiguration.Standard.ConnectionString(
                            d =>
                                d.Server("192.168.178.2")
                                    .Database("seanam_job_cards")
                                    .Port(3306)
                                    .Username("namops")
                                    .Password("3Mili2,87")
                        ))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<WorkAreaMap>())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<JobClassMap>())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<JobTitleMap>())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<OrderNumberMap>())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<JobCardMap>())
                        // .ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(true, true, false))                        
                        .BuildSessionFactory();
                }
            }

            return _sessionFactory;
        }
    }
}