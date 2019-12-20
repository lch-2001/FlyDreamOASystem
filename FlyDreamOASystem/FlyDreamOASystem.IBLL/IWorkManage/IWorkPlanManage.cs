using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IWorkManage
{
    /// <summary>
    /// 工作计划表
    /// </summary>
   public  interface IWorkPlanManage:IBaseUpdateManage
    {
        /// <summary>
        /// 添加工作计划
        /// </summary>
        /// <returns></returns>
        Task<bool> AddWork(string doneWork, string undoneWork, string logWork, string content, 
            Guid userInfoId, Guid dictionaryStatusId, Guid commitUserId);
    }
}
