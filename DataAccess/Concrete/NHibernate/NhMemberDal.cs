using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Concrete.NHibernate;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NHibernate
{
    public class NhMemberDal:NHEntityRepositoryBase<Member>,IMemberDal
    {
        public NhMemberDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
