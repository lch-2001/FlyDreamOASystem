using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using FlyDreamOASystem.Model.Entitys;
using FlyDreamOASystem.Model.Entitys.UserEntity;
namespace FlyDreamOASystem.IDAL.IUserService
{
   public  interface IUserInfoService:IBaseService<Model.Entitys.UserEntity.UserInfo>
    {
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        ISugarQueryable<User, UserInfo, Dictionary,Model.Entitys.PersonnelMattersEntity.Position> GetAllInclude();
    }
}
