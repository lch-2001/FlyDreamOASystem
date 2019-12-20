using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.UserEntity
{
    /// <summary>
    /// 角色菜单对应表
    /// </summary>
  public  class RoleandMenu:BaseEntity
    {
        /// <summary>
        /// 角色外键表
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 菜单外键表
        /// </summary>
        public Guid MenuId { get; set; }
    }
}
