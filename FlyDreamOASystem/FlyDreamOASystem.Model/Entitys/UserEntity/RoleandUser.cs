using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.UserEntity
{
    /// <summary>
    /// 角色用户对应表
    /// </summary>
    public class RoleandUser:BaseEntity
    {
        /// <summary>
        /// 角色外键
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public Guid UserInfoId { get; set; }

    }
}
