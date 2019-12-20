using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys
{
    //数据字典
  public   class Dictionary:BaseEntity
    {
        /// <summary>
        /// 组名
        /// </summary>
        public string GroupName{ get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }
    }
}
