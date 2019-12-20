using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IApprovalManage
{
    /// <summary>
    /// 审批表
    /// </summary>
    public interface IApprovalManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> AddApproval(Guid userId, string name,string season,string icon,Guid dictionaryStateId);
    }
}
