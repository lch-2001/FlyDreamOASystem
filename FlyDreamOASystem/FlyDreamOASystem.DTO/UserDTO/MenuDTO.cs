using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.UserDTO
{
  public   class MenuDTO:BaseDTO
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
        public Guid? ParentId { get; set; }
        ///// <summary>
        ///// 父类名称
        ///// </summary>
        //public string ParentName { get; set; }
        ///// <summary>
        ///// 父类类型
        ///// </summary>
        //public string ParentType { get; set; }
        ///// <summary>
        ///// 父类图标
        ///// </summary>
        //public string ParentIcon { get; set; }
        ///// <summary>
        ///// 父类链接地址
        ///// </summary>
        //public string ParentUrl { get; set; }

    }
}
