using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Abstract.DataAccess;
using Common.Abstract.Entities;
using NHibernate.Linq;

namespace Common.Concrete.NHibernate
{
    public class NHQueryableRepository<T> : IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;

        public NHQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); }
        }
    }
}
