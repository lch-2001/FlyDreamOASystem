using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.WorkEntity
{
    /// <summary>
    /// 工作计划表
    /// </summary>
   public  class WorkPlan:BaseEntity
    {

        /// <summary>
        /// 已完成哪些
        /// </summary>
        public string DoneWork { get; set; }
        /// <summary>
        /// 未完成哪些
        /// </summary>
        public string UndoneWork { get; set; }
        /// <summary>
        /// 这几天要做的事
        /// </summary>
        public string LogWork { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 用户详情表外键
        /// </summary>
        public Guid UserInfoId { get; set; }
        /// <summary>
        /// 完成状态
        /// </summary>
        public Guid DictionaryStatusId { get; set; }
        /// <summary>
        /// 提交上级编号
        /// </summary>
        public Guid CommitUserId { get; set; }
    }
}
