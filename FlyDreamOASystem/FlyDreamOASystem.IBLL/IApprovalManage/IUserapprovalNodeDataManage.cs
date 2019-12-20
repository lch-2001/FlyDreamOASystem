using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IApprovalManage
{
    /// <summary>
    /// 用户审批节点数据
    /// </summary>
    public interface IUserapprovalNodeDataManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userapprovalDataId"></param>
        /// <param name="node"></param>
        /// <param name="dictionaryStateId"></param>
        /// <returns></returns>
        Task<bool> AddNodeData(Guid userapprovalDataId, int node,Guid dictionaryStateId);
    }
}
