using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IUserManage
{
    /// <summary>
    /// 账号详情表
    /// </summary>
   public  interface IUserInfoManage:IBaseManage
    {
  
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userId">账号编号</param>
        /// <param name="name">姓名</param>
        /// <param name="dictionaryId">性别外键</param>
        /// <param name="idCard">身份证号</param>
        /// <param name="birthday">生日日期</param>
        /// <param name="qQ">qq</param>
        /// <param name="phone">手机号</param>
        /// <param name="adress">地址</param>
        /// <param name="ecducation">学历</param>
        /// <param name="state">是否在职</param>
        /// <param name="positionId">职位编号</param>
        /// <param name="headimgurl">头像</param>
        /// <param name="isManager">是否为部门经理</param>
        /// <returns></returns>
        Task<bool> Add(Guid userId, string name, Guid dictionaryId, string idCard, DateTime birthday, int qQ,
            string phone, string adress, string ecducation, bool state, Guid positionId, string headimgurl,
            bool isManager=false
            );
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.UserDTO.UserInfoDTO>> GetAllInclude();
    }
}
