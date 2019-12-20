using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.JournalEntity
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class Worklog:BaseEntity
    {
        /// <summary>
        /// 用户
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }




    }
}
