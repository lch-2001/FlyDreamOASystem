using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.AttendanceEntity
{
  public   class SigninInfo:BaseEntity
    {
        /// <summary>
        /// 迟到总数
        /// </summary>
        public int LateTotal { get; set; }
        /// <summary>
        /// 早退总数
        /// </summary>
        public int QuitTotal { get; set; }
        /// <summary>
        /// 请假总数
        /// </summary>
        public int LeaveTotal { get; set; }
        /// <summary>
        /// 员工总数
        /// </summary>
        public int UserTotal { get; set; }
        /// <summary>
        /// 应到人数
        /// </summary>
        public int DueTotal { get; set; }
        /// <summary>
        /// 实到人数
        /// </summary>
        public int ActualTotal { get; set; }
        /// <summary>
        /// 汇总
        /// </summary>
        public int Summary { get; set; }
 
    }
}
