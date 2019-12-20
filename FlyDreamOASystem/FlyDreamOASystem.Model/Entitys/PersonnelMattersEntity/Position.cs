using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.PersonnelMattersEntity
{
    /// <summary>
    /// 职位表
    /// </summary>
   public class Position:BaseEntity
    {
        /// <summary>
        /// 职位所属部门编号
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 职位名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 职位默认底薪
        /// </summary>
        public decimal Pay { get; set; }
    }
}
