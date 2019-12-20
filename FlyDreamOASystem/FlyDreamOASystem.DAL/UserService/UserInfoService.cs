using System;
using System.Collections.Generic;
using System.Text;
using FlyDreamOASystem.Model.Entitys;
using FlyDreamOASystem.Model.Entitys.UserEntity;
using SqlSugar;
namespace FlyDreamOASystem.DAL.UserService
{
    public class UserInfoService : BaseService<Model.Entitys.UserEntity.UserInfo>, IDAL.IUserService.IUserInfoService
    {
        public  ISugarQueryable<User, UserInfo, Dictionary, Model.Entitys.PersonnelMattersEntity.Position> GetAllInclude()
        {
            return Context.Db.Queryable<User, UserInfo, Dictionary, Model.Entitys.PersonnelMattersEntity.Position>
                ((ur, uo, dy, pn) => new object[] {
              JoinType.Left,uo.DictionaryId==dy.Id,
              JoinType.Left,uo.UserId==uo.Id,
                 JoinType.Left,uo.PositionId==pn.Id,
            });
        }
    }
}
