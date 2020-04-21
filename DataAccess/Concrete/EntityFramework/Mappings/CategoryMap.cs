using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.CategoryID);

            Property(x => x.CategoryName).HasColumnName(@"CategoryName");
        }
    }
}
