using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.UserDTO
{
    /// <summary>
    /// 角色菜单对应表
    /// </summary>
    public class RoleAndMenuDTO:BaseDTO
    {
        /// <summary>
        /// 角色外键表
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 菜单外键表
        /// </summary>
        public Guid MenuId { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string  TypeName{ get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 父类编号
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string ReName { get; set; }

    }
}
