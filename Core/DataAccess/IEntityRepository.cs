using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //IEntity devre dışı bırakabilmek için new () yazarız çünkü IEntity Newlenemez!
    //T ya IEntity olabilir ya da ondan newlenmiş olabilir.
    //class:referans tip olabilir demek
    //generic constraint
   public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetById(int Id);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
