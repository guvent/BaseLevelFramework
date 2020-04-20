using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentNHibernate.Mapping;

namespace DataAccess.Concrete.NHibernate.Mappings
{
    // Kullanılan veritabanına göre mapper değişebilir...
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Products");
            LazyLoad();

            Id(x => x.ProductId).Column("ProductID");
            
            Map(x => x.CategoryId).Column("CategoryId");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
            Map(x => x.UnitPrice).Column("UnitPrice");
            Map(x => x.UnitsInStock).Column("UnitsInStock");
            
        }
    }
}
