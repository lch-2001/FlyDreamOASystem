using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.NotifyEntity
{
    /// <summary>
    /// 栈内信
    /// </summary>
   public  class InstationMessage:BaseEntity
    {
        /// <summary>
        /// 发送人
        /// </summary>
        public Guid SendId { get; set; }
        /// <summary>
        /// 接收人
        /// </summary>
        public Guid ReceiveId { get; set; }
        /// <summary>
        /// 是否已读
        /// </summary>
        public Guid State { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
    }
}
