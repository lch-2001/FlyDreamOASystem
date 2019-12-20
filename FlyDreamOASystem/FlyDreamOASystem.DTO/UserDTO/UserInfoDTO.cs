using System;
using System.Collections.Generic;
using System.Text;

namespace FlyDreamOASystem.DTO.UserDTO
{
    //员工信息表
    public class UserInfoDTO:BaseDTO
    {
        /// <summary>
        /// 员工账号
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPass { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCard { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// QQ账号
        /// </summary>
        public int QQ { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 住址
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public string Ecducation { get; set; }
        /// <summary>
        /// 是否在职
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        public string PositionName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Headimgurl { get; set; }
        /// <summary>
        /// 是否为所属部门经理
        /// </summary>
        public bool IsManager { get; set; }
    }
}
