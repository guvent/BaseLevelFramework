using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetUser(string username, string password)
        {
            return _userDal.Get(u => u.UserName==username && u.Password==password);
        }

        public List<UserRoleItem> GetUserRoleItems(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
