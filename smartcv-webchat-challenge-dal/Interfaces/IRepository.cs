using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace smartcv_webchat_challenge_dal.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entityToDelete);
        void Delete(object id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        void SaveChanges();
    }

}
