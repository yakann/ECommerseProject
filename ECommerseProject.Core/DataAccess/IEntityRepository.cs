using System;
using System.Collections.Generic;
using System.Text;
using ECommerseProject.Core.Entities;
using System.Linq.Expressions;

namespace ECommerseProject.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class ,IEntity, new()//T generic olduğunu gösterir. IEntityden implemente edilmiş olması ve newlenebiliyor olması gerekli.
    {
        T Get(Expression<Func<T,bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
