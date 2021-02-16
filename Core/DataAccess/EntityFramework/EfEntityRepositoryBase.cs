using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<CEntity, CContext> : IEntityRepository<CEntity>

        where CEntity : class, IEntity, new()
        where CContext : DbContext, new()


    {
        public void Add(CEntity entity)
        {
            using (CContext context = new CContext())
            {
                var addedEntity = context.Entry(entity); //db git ekleme yap
                addedEntity.State = EntityState.Added;  //eklenecek nesne
                context.SaveChanges(); //ekle
            }

        }

        public void Delete(CEntity entity)
        {
            using (CContext context = new CContext())
            {
                var deleteEntity = context.Entry(entity); //db git ekleme yap
                deleteEntity.State = EntityState.Deleted;  //silinecek nesne
                context.SaveChanges(); //sil
            }
        }

        public CEntity Get(Expression<Func<CEntity, bool>> filter)
        {

            using (CContext context = new CContext())
            {
                return context.Set<CEntity>().SingleOrDefault(filter);


            }
        }

        public List<CEntity> GetAll(Expression<Func<CEntity, bool>> filter = null)
        {
            using (CContext context = new CContext())
            {
                return filter == null ? context.Set<CEntity>().ToList() : context.Set<CEntity>().Where(filter).ToList();

                // select *from table yap list ekle
            }
        }

        public void Update(CEntity entity)
        {
            using (CContext context = new CContext())
            {
                var updateEntity = context.Entry(entity); //db git ekleme yap
                updateEntity.State = EntityState.Modified;  //silinecek nesne
                context.SaveChanges(); //sil
            }

        }
    }

   
}
