using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.ApprovalEntity
{
    /// <summary>
    /// 抄送表
    /// </summary>
 public    class Copy:BaseEntity
    {
        /// <summary>
        /// 流程编号
        /// </summary>
        public Guid ApprovalFlowId { get; set; }
        /// <summary>
        /// 抄送人
        /// </summary>
        public Guid UserId { get; set; }


    }
}
