using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess

{
   public interface IEntityRepository<C> where C:class,IEntity,new()
    {
        List<C> GetAll(Expression<Func<C, bool>> filter = null); // Linq ile gelir.

        C Get(Expression<Func<C, bool>> filter); // C döndüren, filtre yok ise tümdata istenir.

        void Add(C entity);

        void Update(C entity);

        void Delete(C entity);
    }
}
