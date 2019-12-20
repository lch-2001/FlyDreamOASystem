
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.DTO.ApprovalDTO
{
    /// <summary>
    /// 审批流程表
    /// </summary>
    public    class ApprovalFlowDTO:BaseDTO
    {
        /// <summary>
        /// 审批编号
        /// </summary>
        public Guid approvalId { get; set; }
        /// <summary>
        /// 审批名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  员工姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 详细内容
        /// </summary>
        public string Season { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public string DictionaryState { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int level { get; set; }
     

    }
}
