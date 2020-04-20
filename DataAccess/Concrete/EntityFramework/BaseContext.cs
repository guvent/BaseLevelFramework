using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class BaseContext:DbContext
    {
        public BaseContext()
        {
            Database.SetInitializer<BaseContext>(null);

            // Unit Test App.Config üzerindeki connectionString i kabul etmedi ???
            //Database.Connection.ConnectionString = "Data Source=10.6.2.231;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=Guven__55";

            Database.SetInitializer<BaseContext>(null);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapping zorunlu değil elimizde bulunsun...
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
