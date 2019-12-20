using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.ApprovalEntity
{
    /// <summary>
    /// 流转表
    /// </summary>
   public  class Flow:BaseEntity
    {
        /// <summary>
     /// 流程编号
     /// </summary>
        public Guid ApprovalFlowId { get; set; }
        /// <summary>
        /// 节点
        /// </summary>
        public int Node { get; set; }
        /// <summary>
        /// 用户或上级编号
        /// </summary>
        public Guid? UserId { get; set; }


    }
}
