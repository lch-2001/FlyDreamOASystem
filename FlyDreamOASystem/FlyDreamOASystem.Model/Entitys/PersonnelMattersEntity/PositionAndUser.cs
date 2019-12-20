using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FlyDreamOASystem.Model.Entitys.PersonnelMattersEntity
{
    /// <summary>
    /// 员工职位对应表
    /// </summary>
  public   class PositionAndUser:BaseEntity
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        public Guid PositionId { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public Guid UserInfoId { get; set; }
        /// <summary>
        ///   （升职降职）理由、原因
        /// </summary>
        public string Reason { get; set; }
        
    }
}
