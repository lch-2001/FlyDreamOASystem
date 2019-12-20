using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace FlyDreamOASystem.DAL
{
    [Shared.NotMap]
    public class BaseService<T> : IDAL.IBaseService<T> where T :Model.BaseEntity,new ()
    {
        protected Model.FlyDreamOAContext Context { get; set; } = new Model.FlyDreamOAContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Add(T t)
        {
            try
            {
                Context.Db.Insertable(t).ExecuteCommand();
                return true;
            }
            catch (Exception)
            {
                  
                return false;
            }
         
        }
        /// <summary>
        /// 删除（伪删除）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Guid id)
        {
            try
            {
                T t = new T() { Id = id, IsDelete = true };
                Context.Db.Updateable(t).UpdateColumns(m => new { m.IsDelete }).ExecuteCommand();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public bool Delete(Guid id, bool isDelete)
        {
            if (isDelete)
            {
                try
                {
                    Context.Db.Deleteable<T>().In(id).ExecuteCommand();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else 
            {
                return false;
            }
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public ISugarQueryable<T> GetAll()
        {
           return  Context.Db.Queryable<T>().Where(m=>m.IsDelete==false); 
        }
    }
}
