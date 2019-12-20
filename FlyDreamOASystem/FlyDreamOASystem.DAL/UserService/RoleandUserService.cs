using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using FlyDreamOASystem.Model.Entitys;
using FlyDreamOASystem.Model.Entitys.UserEntity;
using SqlSugar;

namespace FlyDreamOASystem.DAL.UserService
{
    public class RoleandUserService : BaseService<Model.Entitys.UserEntity.RoleandUser>, IDAL.IUserService.IRoleandUserService
    {
        public ISugarQueryable<RoleandUser, Role, UserInfo, User, Dictionary> GetAllInclude()
        {
            return Context.Db.Queryable<RoleandUser, Role, UserInfo, User, Dictionary>((ru, re, uo, ur, dy) => new object[] {
              JoinType.Left,ru.RoleId==re.Id,
              JoinType.Left,ru.UserInfoId==uo.Id,
              JoinType.Left,uo.DictionaryId==dy.Id,
              JoinType.Left,uo.UserId==ur.Id
            });
        }
    }
}
