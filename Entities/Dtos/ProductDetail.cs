using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ProductDetail
    {
        public virtual int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
