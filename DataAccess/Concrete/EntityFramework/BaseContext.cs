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
        public DbSet<User> Users2 { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapping zorunlu değil elimizde bulunsun...
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}
