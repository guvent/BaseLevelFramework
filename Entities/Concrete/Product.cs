using Common.Abstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public virtual int ProductID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual short UnitsInStock { get; set; }

    }
}
