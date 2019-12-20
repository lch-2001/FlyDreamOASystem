using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.IDAL.IUserService
{
  public   interface IRoleandUserService:IBaseService<Model.Entitys.UserEntity.RoleandUser>
    {
           ISugarQueryable<Model.Entitys.UserEntity.RoleandUser,Model.Entitys.UserEntity.Role,
            Model.Entitys.UserEntity.UserInfo,Model.Entitys.UserEntity.User,Model.Entitys.Dictionary> 
            GetAllInclude();
    }
}
