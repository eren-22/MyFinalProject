using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // Sadece class olabileceğini söyleriz. Aynı zamanda IEntity ya da inheritance almış classları olabilir. (Referans tipli!!) int, string vs. olamaz. (Generic Constraint)
    // Aynı zamanda "new()" diyoruz çünkü IEntity'nin olmasını da istemeyiz.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);    // Filtreleme! , filtre vermeyebiliriz de..
        T Get(Expression<Func<T, bool>> filter);    // Tek bir data getirmek için!
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}