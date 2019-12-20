using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.IBLL.IUserManage
{
    /// <summary>
    /// 菜单
    /// </summary>
   public  interface IMenuManage
    {
    
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> AddMenu(string name,Guid typeId,string icon,string url,Guid parentId);
        Task<bool> AddMenu(string name, Guid typeId, string icon, string url);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteMenu(Guid id);
        Task<bool> DeleteMenu(Guid id,bool isDelete);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.UserDTO.MenuDTO>> GetAll();
    }
}
