using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.IDAL.IUserService
{
  public   interface IRoleandMenuService:IBaseService<Model.Entitys.UserEntity.RoleandMenu>
    {
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        ISugarQueryable<Model.Entitys.UserEntity.RoleandMenu,Model.Entitys.UserEntity.Menu,Model.Entitys.UserEntity.Role,Model.Entitys.Dictionary> GetAllInclude();
    }
}
