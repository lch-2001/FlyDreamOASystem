using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlyDreamOASystem;
namespace FlyDreamOASystem.IBLL
{
    public interface IDictionaryManage
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        Task<bool> AddDictionary(string groupName,string value);
       /// <summary>
       /// 删除(伪删除)
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        Task<bool> DeleteDictionary(Guid id);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        Task<bool> DeleteDictionary(Guid id ,bool isDelete);
        /// <summary>
        /// 获取所有字典数据
        /// </summary>
        /// <returns></returns>
        Task<List<DTO.DictionaryDTO>> GetAllDictionary();
    }
}
