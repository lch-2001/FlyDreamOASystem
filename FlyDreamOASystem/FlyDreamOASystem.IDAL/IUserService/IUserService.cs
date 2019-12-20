using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IDAL.IUserService
{
  public   interface IUserService:IBaseService<Model.Entitys.UserEntity.User>
    {
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        Task<bool> CehckingUser(string userName,string pass);
    }
}
