using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IUserManage
{
    /// <summary>
    /// 角色菜单对应
    /// </summary>
   public  interface IRoleandMenuManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="roleId">角色Id</param>
        /// <param name="menuId">菜单Id</param>
        /// <returns></returns>
        Task<bool> Add(Guid roleId,Guid  menuId);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.UserDTO.RoleAndMenuDTO>> GetAll();
    }
}
