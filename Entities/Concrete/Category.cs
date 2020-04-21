using System;
using System.Collections.Generic;
using System.Text;
using Common.Abstract.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public virtual int CategoryID { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
