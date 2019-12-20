using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.INotifyManage
{
    /// <summary>
    /// 栈内信
    /// </summary>
  public   interface IInstationMessageManage: IBaseUpdateManage
    {
        /// <summary>
        /// 添加栈内信
        /// </summary>
        /// <returns></returns>
        Task<bool> AddMessage(Guid sendId, Guid receiveId, Guid dictionaryStateId, string content);
    }
}
