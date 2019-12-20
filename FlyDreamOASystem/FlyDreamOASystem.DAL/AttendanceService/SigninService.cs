using System;
using System.Collections.Generic;
using System.Text;
using FlyDreamOASystem.Model.Entitys.AttendanceEntity;
using SqlSugar;

namespace FlyDreamOASystem.DAL.AttendanceService
{
    public class SigninService : BaseService<Model.Entitys.AttendanceEntity.Signin>, IDAL.IAttendanceService.ISigninService
    {
        public ISugarQueryable<Signin, Model.Entitys.Dictionary,Model.Entitys.UserEntity.UserInfo> GetAllInclude()
        {
            return Context.Db.Queryable<Signin, Model.Entitys.Dictionary, Model.Entitys.UserEntity.UserInfo>((sn, dy,uo) => new object[]{
               JoinType.Left,sn.DictionaryStateId==dy.Id,
               JoinType.Left,sn.UserId==uo.Id
            });
        }
    }
}
