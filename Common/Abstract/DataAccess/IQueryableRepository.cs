using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Abstract.Entities;

namespace Common.Abstract.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
