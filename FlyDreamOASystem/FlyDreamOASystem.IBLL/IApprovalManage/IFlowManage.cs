using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IApprovalManage
{
    /// <summary>
    /// 流转表
    /// </summary>
    public interface IFlowManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> AddFlow(Guid approvalFlowId, int node, Guid? UserId);
    }
}
