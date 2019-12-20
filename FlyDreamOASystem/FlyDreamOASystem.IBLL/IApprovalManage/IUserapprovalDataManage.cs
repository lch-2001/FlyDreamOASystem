using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IApprovalManage
{
    /// <summary>
    /// 用户审批数据
    /// </summary>
    public interface IUserapprovalDataManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> Add(Guid approvalId, int node, Guid userId);
    }
}
