using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL
{
    [Shared.NotMap]
    public  interface IBaseUpdateManage
    {
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(Guid id);
        Task<bool> Delete(Guid id, bool isDelete);
    }
}
