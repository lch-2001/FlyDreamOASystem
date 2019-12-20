using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.UserEntity
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public   class Menu:BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public Guid TypeId { get; set; }
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
        [SugarColumn(IsNullable = true)]
        public Guid ParentId { get; set; }
    }
}
