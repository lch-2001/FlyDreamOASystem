using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.UserDTO;

namespace FlyDreamOASystem.BLL.UserManage
{
    public  class RoleandUserManage : IBLL.IUserManage.IRoleandUserManage
    {
        private readonly IDAL.IUserService.IRoleandUserService Service;
        public RoleandUserManage(IDAL.IUserService.IRoleandUserService service) 
        {
            Service = service;
        }

        public  async Task<bool> Add(Guid roleId,Guid userId)
        {
          return  await  Task.Run(()=> 
            {
               return  Service.Add(new Model.Entitys.UserEntity.RoleandUser()
                {
                   RoleId=roleId,
                   UserInfoId=userId,
                   Id=Guid.NewGuid()
                });
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
           return await Task.Run(()=> 
            {
                return Service.Delete(id);
            });
        }

        public async Task<bool> DeleteMenu(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Service.Delete(id,isDelete);
            });
        }

        public async  Task<List<RoleandUserDTO>> GetAll()
        {
          return await  Task.Run(()=> 
            {
                return Service.GetAllInclude().Select((ru, re, uo, ur, dy) => new DTO.UserDTO.RoleandUserDTO
                {
                   Name=uo.Name,
                   RoleName=re.Name,
                   UserName=ur.Name,
                   Id=ru.Id,
                   CreateTime=ru.CreateTime
                }).ToList();
            });
        }
    }
}
