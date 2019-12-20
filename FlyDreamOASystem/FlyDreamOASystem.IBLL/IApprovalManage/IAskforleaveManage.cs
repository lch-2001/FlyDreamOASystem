using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IApprovalManage
{
    /// <summary>
    /// 请假表
    /// </summary>
    public interface IAskforleaveManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> AddAskfor(Guid userId,DateTime startTime,DateTime endTime,int dayCount,string reason,Guid dictionaryStateId);
    }
}
