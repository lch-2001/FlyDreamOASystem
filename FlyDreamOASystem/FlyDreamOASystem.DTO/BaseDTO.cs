using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO
{
  public   abstract class BaseDTO
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
