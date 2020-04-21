using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.ProductID);

            Property(x => x.ProductID).HasColumnName(@"ProductID");
            Property(x => x.CategoryID).HasColumnName(@"CategoryID");
            Property(x => x.ProductName).HasColumnName(@"ProductName");
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit");
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice");
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock");
        }
    }
}
