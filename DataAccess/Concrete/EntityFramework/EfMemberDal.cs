using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal:EfEntityRepositoryBase<Member,BaseContext>,IMemberDal
    {
    }
}
