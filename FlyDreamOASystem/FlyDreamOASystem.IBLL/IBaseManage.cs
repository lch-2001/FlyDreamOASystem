using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL
{
    [Shared.NotMap]
    public  interface IBaseManage
    {
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteMenu(Guid id);
        Task<bool> DeleteMenu(Guid id, bool isDelete);
    }
}
