using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,BaseContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (BaseContext context = new BaseContext())
            {
                var result = from ur in context.UserRoles
                    join r in context.Roles on ur.UserId equals r.Id
                    where ur.UserId == user.Id
                    select new UserRoleItem
                    {
                        RoleName = r.Name
                    };
                return result.ToList();
            }
        }
    }
}
