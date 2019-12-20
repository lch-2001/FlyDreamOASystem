using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IAttendanceManage
{
 public    interface ISigninManage:IBaseManage
    {
        /// <summary>
        /// 添加考勤
        /// </summary>
        /// <returns></returns>
        Task<bool> AddSignin(Guid userId,Guid dictionaryTypeId,bool late,bool quit,string summary,Guid dictionaryStateId);
      
    }
}
