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
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName(@"ProductId");
            Property(x => x.CategoryId).HasColumnName(@"CategoryId");
            Property(x => x.ProductName).HasColumnName(@"ProductName");
            Property(x => x.QuantityPerUnit).HasColumnName(@"QuantityPerUnit");
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice");
            Property(x => x.UnitsInStock).HasColumnName(@"UnitsInStock");
        }
    }
}
