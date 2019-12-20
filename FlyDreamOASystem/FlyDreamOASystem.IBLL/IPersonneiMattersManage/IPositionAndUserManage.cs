using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IPersonneiMattersManage
{
    /// <summary>
    /// 员工职位处理
    /// </summary>
    public interface IPositionAndUserManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="positionId"></param>
        /// <param name="userInfoId"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        Task<bool> Add(Guid positionId, Guid userInfoId, string reason);
    }
}
