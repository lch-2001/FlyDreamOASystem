using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FlyDreamOASystem.IDAL
{
    [Shared.NotMap]
    public interface IBaseService<T> where T : Model.BaseEntity,new ()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        bool Add(T t);
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        bool Delete(Guid id);
        bool Delete(Guid id,bool isDelete);
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        ISugarQueryable<T> GetAll();
        ///// <summary>
        ///// 链表
        ///// </summary>
        ///// <returns></returns>
        //ISugarQueryable<T,T> GetAllIncludeTwo(Expression<Func<T,bool>> s);
        //ISugarQueryable<T, T, T> GetAllIncludeThree();
        //ISugarQueryable<T, T, T,T> GetAllIncludeFour();
        //ISugarQueryable<T, T, T, T,T> GetAllIncludeFive();
    }
}
