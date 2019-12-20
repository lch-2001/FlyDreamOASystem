using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.Model.Entitys.UserEntity;

namespace FlyDreamOASystem.BLL.UserManage
{
    public class RoleManage : IBLL.IUserManage.IRoleManage
    {
        private readonly IDAL.IUserService.IRoleService Role;
        public RoleManage(IDAL.IUserService.IRoleService role)
        {
            Role = role;          
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async  Task<bool> AddRole(string name)
        {
          return await   Task.Run(()=> 
          {
              return Role.Add(new Model.Entitys.UserEntity.Role() 
              {
                Id=Guid.NewGuid(),
                Name=name
              });
          });
        }
        /// <summary>
        /// 删除(伪删除)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteMenu(Guid id)
        {
          return await   Task.Run(()=> 
            {
              return   Role.Delete(id);
            });
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public async Task<bool> DeleteMenu(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Role.Delete(id,isDelete);
            });
        }
        /// <summary>
        /// 获取所有角色
        /// </summary>
        /// <returns></returns>
        public async Task<List<DTO.UserDTO.RoleDTO>> GetAll()
        {
           return await Task.Run(()=> 
            {
              return   Role.GetAll().Select(m=>new DTO.UserDTO.RoleDTO() 
                {
                 Id=m.Id,
                 CreateTime=m.CreateTime,
                 Name=m.Name
                }).ToList();
            });
        }
    }
}
