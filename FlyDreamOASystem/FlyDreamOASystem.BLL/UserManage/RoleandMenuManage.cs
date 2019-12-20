using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.UserDTO;

namespace FlyDreamOASystem.BLL.UserManage
{
    public class RoleandMenuManage : IBLL.IUserManage.IRoleandMenuManage
    {
        private readonly IDAL.IUserService.IRoleandMenuService Service;
        public RoleandMenuManage(IDAL.IUserService.IRoleandMenuService service) 
        {
            Service = service;
            
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public async  Task<bool> Add(Guid roleId, Guid menuId)
        {
           return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.UserEntity.RoleandMenu() 
                {
                 Id=Guid.NewGuid(),
                 MenuId=menuId,
                 RoleId=roleId
                });
            });
        }
        /// <summary>
        /// 删除(伪删除)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async  Task<bool> DeleteMenu(Guid id)
        {
           return await Task.Run(()=> 
            {
              return   Service.Delete(id);
            });
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public async  Task<bool> DeleteMenu(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Service.Delete(id,isDelete);
            });
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public async  Task<List<RoleAndMenuDTO>> GetAll()
        {
          return  await Task.Run(()=> 
            {

              return  Service.GetAllInclude().Select((ru,mu,re,dy)=>new DTO.UserDTO.RoleAndMenuDTO 
                {
                  Id=ru.Id,
                  Name=mu.Name,
                  CreateTime=ru.CreateTime,
                  Icon=mu.Icon,
                  ReName=re.Name,
                  TypeName=dy.Value,
                  ParentId=mu.ParentId,
                  Url=mu.Url,
                  MenuId=ru.MenuId,
                  RoleId=ru.MenuId,
                  
                }).ToList();
            });
        }
    }
}
