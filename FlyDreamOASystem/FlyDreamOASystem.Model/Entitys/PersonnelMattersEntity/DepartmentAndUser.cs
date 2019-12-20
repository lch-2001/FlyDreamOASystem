using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.PersonnelMattersEntity
{
    /// <summary>
    /// 部门员工对应表
    /// </summary>
  public   class DepartmentAndUser:BaseEntity
    {
        /// <summary>
        /// 员工外键
        /// </summary>
        public Guid UserId { get; set; }
       /// <summary>
       /// 部门外键表
       /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }
    }
}
