using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.ApprovalDTO
{
    /// <summary>
    /// 请假表
    /// </summary>
   public  class AskforleaveDTO:BaseDTO
    {
     
        /// <summary>
        ///  员工编号
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        ///天数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public Guid DictionaryState { get; set; }
          



    }
}
