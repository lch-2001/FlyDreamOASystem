using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model
{
   public  abstract class BaseEntity
    {

        [SugarColumn(IsPrimaryKey = true)]
        public Guid Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
