using System;
using System.Collections.Generic;
using System.Text;
using FlyDreamOASystem.Model.Entitys.UserEntity;
using SqlSugar;

namespace FlyDreamOASystem.DAL.UserService
{
    public class RoleandMenuService : BaseService<Model.Entitys.UserEntity.RoleandMenu>, IDAL.IUserService.IRoleandMenuService
    {
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public  ISugarQueryable<RoleandMenu,Menu,Role,Model.Entitys.Dictionary> GetAllInclude()
        {
            return Context.Db.Queryable<RoleandMenu, Menu, Role,Model.Entitys.Dictionary>((ru, mu, re,dy) => new object[] {
              JoinType.Left,ru.RoleId==re.Id,
              JoinType.Left,ru.MenuId==mu.Id,
              JoinType.Left,dy.Id==mu.TypeId,
            });
        }
    }
}
