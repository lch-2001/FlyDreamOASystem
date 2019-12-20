using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IPersonneiMattersManage
{
    /// <summary>
    /// 职位
    /// </summary>
    public interface IPositionManage : IBaseUpdateManage
    {
        /// <summary>
        /// 添加职位
        /// </summary>
        /// <param name="DepartmentId"></param>
        /// <param name="Name"></param>
        /// <param name="Pay"></param>
        /// <returns></returns>
        Task<bool> AddPosition(Guid departmentId, string name, decimal pay);
    }
}
