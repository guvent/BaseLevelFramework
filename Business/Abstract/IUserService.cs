using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUserService
    {
        User GetUser(string username, string password);
        List<UserRoleItem> GetUserRoleItems(User user);
    }
}
