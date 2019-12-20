using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IPersonneiMattersManage
{

    /// <summary>
    /// 部门和员工处理
    /// </summary>
    public interface IDepartmentAndUserManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> Add(Guid userId, Guid departmentId, string reason);
    }
}
