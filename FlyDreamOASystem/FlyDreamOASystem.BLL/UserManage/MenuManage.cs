using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.UserDTO;

namespace FlyDreamOASystem.BLL.UserManage
{
    public class MenuManage : IBLL.IUserManage.IMenuManage
    {
        private readonly IDAL.IUserService.IMenuService Menu;
        public MenuManage(IDAL.IUserService.IMenuService menu) 
        {
            Menu = menu;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="name"></param>
        /// <param name="typeId"></param>
        /// <param name="icon"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public async  Task<bool> AddMenu(string name, Guid typeId, string icon, string url)
        {
          return  await Task.Run(() =>
             {
                 return Menu.Add(new Model.Entitys.UserEntity.Menu()
                 {
                     Id=Guid.NewGuid(),
                     Icon=icon,
                     Name=name,
                     Url=url,
                     TypeId=typeId

                 });
             });
        }

        public async  Task<bool> AddMenu(string name, Guid typeId, string icon, string url, Guid parentId)
        {
            return await Task.Run(()=> 
            {
                return Menu.Add(new Model.Entitys.UserEntity.Menu()
                {
                    Id = Guid.NewGuid(),
                    Icon = icon,
                    Name = name,
                    Url = url,
                    TypeId = typeId,
                    ParentId=parentId

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
                return Menu.Delete(id);
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
                return Menu.Delete(id,isDelete);
            });
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public async  Task<List<MenuDTO>> GetAll()
        {
        return    await Task.Run(()=> 
           {
               return Menu.GetAll().Select(m=>new DTO.UserDTO.MenuDTO() 
               {
                  Id=m.Id,
                  CreateTime=m.CreateTime,
                  Icon=m.Icon,
                  Name=m.Name,
                  ParentId=m.ParentId,
                  TypeId=m.TypeId,
                  Url=m.Url
               }).ToList();
           });
        }
    }
}
