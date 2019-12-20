using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.UserDTO
{
    /// <summary>
    /// 角色用户对应表
    /// </summary>
    public class RoleandUserDTO:BaseDTO
    {
        /// <summary>
        /// 员工账号
        /// </summary>
        public string  UserName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }


    }
}
