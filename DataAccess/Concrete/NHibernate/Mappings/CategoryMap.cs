using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();

            Id(x => x.CategoryID).Column("CategoryID");

            Map(x => x.CategoryName).Column("CategoryName");

        }
    }
}
