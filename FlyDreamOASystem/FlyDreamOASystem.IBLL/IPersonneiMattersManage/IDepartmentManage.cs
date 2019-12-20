using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IPersonneiMattersManage
{
    /// <summary>
    /// 部门处理
    /// </summary>
    public interface IDepartmentManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <returns></returns>
        Task<bool> AddDepartment(string name);
        Task<bool> AddDepartment(string name,Guid parentId);
    }
}
