using System;
using System.Collections.Generic;
using System.Text;
namespace FlyDreamOASystem.DTO.ApprovalDTO
{
    /// <summary>
    /// 审批表
    /// </summary>
    public class ApprovalDTO:BaseDTO
    {
        /// <summary>
        /// 审批名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  员工姓名
        /// </summary>
        public string   UserName{ get; set; }
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
             



    }
}
