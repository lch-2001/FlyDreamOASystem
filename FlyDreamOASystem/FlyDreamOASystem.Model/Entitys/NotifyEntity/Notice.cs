using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.NotifyEntity
{
    /// <summary>
    /// 公告表
    /// </summary>
   public   class Notice:BaseEntity
    {
        /// <summary>
        /// 发布公告的用户
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 公告类型
        /// </summary>
        public Guid DictionaryId { get; set; }
        /// <summary>
        /// 通知状态
        /// </summary>
        public Guid DictionaryStateId { get; set; }
        /// <summary>
        /// 接受公告的部门外键
        /// </summary>
        public Guid  TakeUserId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 公告详情
        /// </summary>
        public string Detail { get; set; }
        /// <summary>
        /// 已阅读人数
        /// </summary>
        public long Read { get; set; }
        /// <summary>
        /// 未阅读人数
        /// </summary>
        public long UnRead { get; set; }
        /// <summary>
        /// 排序（排序根据通知状态决定）
        /// </summary>
        public int Order { get; set; }
    }
}
