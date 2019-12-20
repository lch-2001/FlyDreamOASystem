using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IWorkManage
{
    /// <summary>
    /// 便签表
    /// </summary>
    public interface IMemoManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加便签
        /// </summary>
        /// <returns></returns>
        Task<bool> AddMemo(Guid userId,string content);
    }
}
