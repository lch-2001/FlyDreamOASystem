using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.WorkEntity
{
    /// <summary>
    /// 便签表
    /// </summary>
   public  class Memo:BaseEntity
    {
        /// <summary>
        /// 功能名
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 用户详情外键
        /// </summary>
        public Guid UserInfoId { get; set; }
    }
}
