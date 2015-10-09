using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public interface IRepository { }

    /// <summary>
    /// 仓储
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> : IRepository where TEntity : class
    {
        /// <summary>
        /// 通过主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity FindByID(int id);
        /// <summary>
        /// 通过主键查询
        /// </summary>
        /// <param name="uniqueID"></param>
        /// <returns></returns>
        TEntity FindByID(Guid uniqueID);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        void Delete(TEntity entity);
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="entity"></param>
        void Save(TEntity entity, Expression<Func<TEntity, object>> expression = null);
    }
}
