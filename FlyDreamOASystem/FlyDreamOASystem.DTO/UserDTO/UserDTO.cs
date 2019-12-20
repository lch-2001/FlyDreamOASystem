using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.UserDTO
{
    /// <summary>
    ///员工表
    /// </summary>
    public class UserDTO:BaseDTO
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 是否在职
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
    }
}
