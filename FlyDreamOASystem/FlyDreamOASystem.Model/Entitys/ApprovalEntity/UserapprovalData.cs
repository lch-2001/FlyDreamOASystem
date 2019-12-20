using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.ApprovalEntity
{
    /// <summary>
    /// 用户审批数据表
    /// </summary>
    public class UserapprovalData:BaseEntity
    {
        /// <summary>
        /// 审批表编号
        /// </summary>
        public Guid ApprovalId { get; set; }
       /// <summary>
       /// 节点
       /// </summary>
        public int Node { get; set; }
        /// <summary>
        /// 抄送人
        /// </summary>
        public Guid UserId { get; set; }


    }
}
