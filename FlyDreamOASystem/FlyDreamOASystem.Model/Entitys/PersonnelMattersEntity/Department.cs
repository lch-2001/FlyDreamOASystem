using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.PersonnelMattersEntity
{
    /// <summary>
    /// 部门表
    /// </summary>
   public  class Department:BaseEntity
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 父级编号
        /// </summary>
        [SugarColumn(IsNullable = true) ]
        public Guid ParentId { get; set; }
       
    }
}
