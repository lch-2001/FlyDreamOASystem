using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.DAL.UserService
{
    public class UserService : BaseService<Model.Entitys.UserEntity.User>, IDAL.IUserService.IUserService
    {
        public async  Task<bool> CehckingUser(string userName, string pass)
        {
              if (await GetAll().AnyAsync(m => m.Name == userName && m.Pwd == pass))
                {
                    return true;
                }
              else 
                {
                    return false;
                }
        }
    }
}
