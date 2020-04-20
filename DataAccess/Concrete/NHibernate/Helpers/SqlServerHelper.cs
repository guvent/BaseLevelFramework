using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Common.Concrete.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper:NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            //// Postgresql test edilecek ...
            //return Fluently.Configure().Database(
            //    PostgreSQLConfiguration.PostgreSQL82.ConnectionString(c =>
            //        {
            //            c.Database("");
            //            c.Host("");
            //            c.Port(5432);
            //            c.Username("");
            //            c.Password("");
            //        }
            //    )).Mappings(t=>t.FluentMappings.AddFromAssembly(assembly:Assembly.GetExecutingAssembly())).BuildSessionFactory();

            // .net core conf dan alması gerekiyor düzeltilecek....
            //string connectionString =
            //    "Data Source=10.6.2.231;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=Guven__55";

            //return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
            //    .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();

            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(c=>c.FromConnectionStringWithKey("BaseContext")))
                .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();

        }
    }
}
