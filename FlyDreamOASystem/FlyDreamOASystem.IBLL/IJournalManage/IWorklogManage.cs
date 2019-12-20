using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IJournalManage
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public interface IWorklogManage:IBaseManage
    {
        /// <summary>
        /// 添加操作日志
        /// </summary>
        /// <returns></returns>
        Task<bool> AddLogin(Guid userId, string content);
    }
}
