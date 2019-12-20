using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IUserManage
{
    /// <summary>
    /// 用户表
    /// </summary>
  public   interface IUserManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> RegisterUser(string name,string pass);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.UserDTO.UserDTO>> GetAll();
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        Task<bool> ExistsUser(string userName, string pass);
    }
}
