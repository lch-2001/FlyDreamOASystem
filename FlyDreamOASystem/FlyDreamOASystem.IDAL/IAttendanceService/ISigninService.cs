using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.IDAL.IAttendanceService
{
 public    interface ISigninService:IBaseService<Model.Entitys.AttendanceEntity.Signin>
    {
        /// <summary>
        /// 获取所有考勤数据
        /// </summary>
        /// <returns></returns>
        ISugarQueryable<Model.Entitys.AttendanceEntity.Signin,Model.Entitys.Dictionary,Model.Entitys.UserEntity.UserInfo> GetAllInclude();
    }
}
