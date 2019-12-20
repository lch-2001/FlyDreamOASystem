using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.WorkEntity
{
     /// <summary>
    /// 工作台
    /// </summary>
   public  class Bench:BaseEntity
    {
        /// <summary>
        /// 功能名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 功能Url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 用户详情表外键
        /// </summary>
        public Guid UserInfoId { get; set; }
    }
}
