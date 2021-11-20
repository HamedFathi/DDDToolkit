using DDDToolkit.Domain;
using DDDToolkit.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DDDToolkit.Repositories
{
    public interface ICrudRepository<T> where T : class, IAggregateRoot
    {
        Task<T> FindByKey(object key, params Expression<Func<T, object>>[] includeProperties);
        Task<IReadOnlyCollection<T>> FindBy(Specification<T> specification,
            params Expression<Func<T, object>>[] includeProperties);
        Task<IReadOnlyCollection<T>> FindBy(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties);

        Task<bool> Add(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
    }
}
