using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IUserManage
{
  public   interface IRoleandUserManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="roleId">角色编号</param>
        /// <param name="userId">用户编号</param>
        /// <returns></returns>
        Task<bool> Add(Guid roleId,Guid userId);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.UserDTO.RoleandUserDTO>> GetAll();
    }
}
