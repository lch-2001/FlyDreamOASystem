using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IApprovalManage
{
    /// <summary>
    /// 抄送表
    /// </summary>
    public interface ICopyManage:IBaseManage
    {
        Task<bool> AddCopy(Guid approvalFlowId, Guid userId);
    }
}
