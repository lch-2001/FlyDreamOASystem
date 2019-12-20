using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.AttendanceEntity
{
     /// <summary>
     /// 考勤、签到表
     /// </summary>
   public  class Signin:BaseEntity
    {
        /// <summary>
        /// 员工详情外键
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 类型(签到/签退)
        /// </summary>
        public Guid DictionaryTypeId { get; set; }
        /// <summary>
        ///  是否迟到
        /// </summary>
        public bool Late { get; set; }
        /// <summary>
        /// 是否早退
        /// </summary>
        public bool Quit { get; set; }
        /// <summary>
        /// 汇总
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 考勤状态
        /// </summary>
        public Guid DictionaryStateId { get; set; }

    }
}
