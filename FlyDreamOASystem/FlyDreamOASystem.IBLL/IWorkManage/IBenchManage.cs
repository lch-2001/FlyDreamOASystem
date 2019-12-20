using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IWorkManage
{
    /// <summary>
    /// 工作台
    /// </summary>
    public interface IBenchManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加工作台
        /// </summary>
        /// <returns></returns>
        Task<bool> AddBench(string name, string url, Guid userInfoId);
    }
}
