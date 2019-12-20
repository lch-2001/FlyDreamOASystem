using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IAttendanceManage
{
 public  interface ISigninInfoManage:IBaseManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> Add(int lateTotal, int quitTotal, int leaveTotal, int userTotal, int dueTotal, int actualTotal, int summary);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.AttendanceDTO.SigninInfoDTO>> GetAll();
    }
}
