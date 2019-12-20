using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.UserDTO;

namespace FlyDreamOASystem.BLL.UserManage
{

    public class UserManage : IBLL.IUserManage.IUserManage
    {
        private readonly IDAL.IUserService.IUserService User;
        public UserManage(IDAL.IUserService.IUserService user) 
        {
            User = user;
        }
        public async  Task<bool> RegisterUser(string name,string pass)
        {
          return await   Task.Run(()=> 
            {
            if (User.GetAll().Any(m => m.Name != name))
            {
                return User.Add(new Model.Entitys.UserEntity.User()
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Pwd = pass
                    });

                }
                else
                {
                    return false;
                }
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
           return await Task.Run(()=> 
            {
                return User.Delete(id);
            });
        }

        public async  Task<bool> DeleteMenu(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return User.Delete(id,isDelete);
            });
        }

        public async  Task<bool> ExistsUser(string userName, string pass)
        {
             return  await  User.CehckingUser(userName,pass);
        }

        public async  Task<List<UserDTO>> GetAll()
        {
            return await Task.Run(()=> 
             {
                 return User.GetAll().Select(m=> new DTO.UserDTO.UserDTO
                 {
                    Id=m.Id,
                    State=m.State,
                    CreateTime=m.CreateTime,
                    LastLoginTime=m.LastLoginTime,
                    Name=m.Name,
                    Pwd=m.Pwd
                 }).ToList();
             });
        }
    }
}
