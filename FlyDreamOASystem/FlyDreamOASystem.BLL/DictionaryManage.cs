using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO;

namespace FlyDreamOASystem.BLL
{
    public class DictionaryManage : IBLL.IDictionaryManage
    {
        private readonly IDAL.IDictionaryService Dictionary;
        public DictionaryManage(IDAL.IDictionaryService dictionary)
        {
            Dictionary = dictionary;
        }
        /// <summary>
        /// 添加字典
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async  Task<bool> AddDictionary(string groupName, string value)
        {
            return await Task.Run(()=> 
            {
                return Dictionary.Add(new Model.Entitys.Dictionary() 
                {
                  Id=Guid.NewGuid(),
                  GroupName=groupName,
                  Value=value
                });
            });
        }
        /// <summary>
        /// 删除字典(伪删除)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async  Task<bool> DeleteDictionary(Guid id)
        {
            return await Task.Run(()=> 
            {
                return Dictionary.Delete(id);
            });
        }
        /// <summary>
        /// 删除字典
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public async  Task<bool> DeleteDictionary(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Dictionary.Delete(id,isDelete);
            });
        }
        /// <summary>
        /// 获取所有字典数据
        /// </summary>
        /// <returns></returns>
        public async  Task<List<DictionaryDTO>> GetAllDictionary()
        {
            return await Task.Run(()=> 
            {
                return Dictionary.GetAll().Select(m => new DTO.DictionaryDTO() 
                {
                  Id=m.Id,
                  CreateTime=m.CreateTime,
                  GroupName=m.GroupName,
                  Value=m.Value
                }).ToList();
            });
        }
    }
}
