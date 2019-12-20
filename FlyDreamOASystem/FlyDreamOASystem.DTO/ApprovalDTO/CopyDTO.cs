using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.DTO.ApprovalDTO
{
    /// <summary>
    /// 抄送表
    /// </summary>
 public    class CopyDTO:BaseDTO
    {
        /// <summary>
        /// 流程编号
        /// </summary>
        public Guid ApprovalFlowId { get; set; }
        /// <summary>
        /// 抄送员工
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public Guid UserId { get; set; }
    }
}
