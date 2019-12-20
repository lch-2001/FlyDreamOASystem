using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.AttendanceDTO
{
    /// <summary>
    /// 考勤、签到
    /// </summary>
    public class SigninDTO:BaseDTO
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 类型(签到/签退)
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        ///  是否迟到
        /// </summary>
        public bool Late { get; set; }
        /// <summary>
        /// 是否早退
        /// </summary>
        public bool Quit { get; set; }
        /// <summary>
        /// 汇总
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 考勤状态
        /// </summary>
        public string DictionaryStateName { get; set; }
    }
}
