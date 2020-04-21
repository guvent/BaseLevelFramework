using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Abstract.DataAccess;
using Entities.Concrete;

namespace Entities.Abstract
{
    public interface IMemberDal:IEntityRepository<Member>
    {
    }
}
