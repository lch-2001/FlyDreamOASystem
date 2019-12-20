using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.ApprovalEntity
{
    /// <summary>
    /// 审批流程表
    /// </summary>
    public    class ApprovalFlow:BaseEntity
    {
        /// <summary>
        /// 审批编号
        /// </summary>
        public Guid approvalId { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int level { get; set; }
        

    }
}
