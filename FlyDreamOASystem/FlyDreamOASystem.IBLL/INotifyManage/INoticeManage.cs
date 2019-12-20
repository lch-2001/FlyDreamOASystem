using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.INotifyManage
{
    /// <summary>
    /// 公告
    /// </summary>
    public interface INoticeManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加公告
        /// </summary>
        /// <returns></returns>
        Task<bool> AddNotice(Guid sendUserId, Guid dictionaryTypeId, Guid dictionaryStateId, Guid takeUserId,
             string title, string detail, long read, long unRead, int order
            );
    }
}
