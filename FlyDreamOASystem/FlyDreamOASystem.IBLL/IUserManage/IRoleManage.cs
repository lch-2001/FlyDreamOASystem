using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IUserManage
{
  /// <summary>
  /// 角色
  /// </summary>
   public  interface IRoleManage:IBaseManage
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        Task<bool> AddRole(string name);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.UserDTO.RoleDTO>> GetAll();
    }
}
