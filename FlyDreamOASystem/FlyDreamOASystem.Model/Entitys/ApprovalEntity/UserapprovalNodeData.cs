using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.ApprovalEntity
{
    /// <summary>
    /// 用户审批节点数据表
    /// </summary>
    public class UserapprovalNodeData:BaseEntity
    {
        /// <summary>
        /// 审批数据编号
        /// </summary>
        public Guid UserapprovalDataId { get; set; }
        /// <summary>
        /// 节点
        /// </summary>
        public int Node { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public Guid DictionaryStateId { get; set; }


    }
}
