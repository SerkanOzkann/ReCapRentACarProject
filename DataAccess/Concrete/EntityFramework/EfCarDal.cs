using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedEntity = context.Entry(entity); //db git ekleme yap
                addedEntity.State = EntityState.Added;  //eklenecek nesne
                context.SaveChanges(); //ekle
            }
            
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deleteEntity = context.Entry(entity); //db git ekleme yap
                deleteEntity.State = EntityState.Deleted;  //silinecek nesne
                context.SaveChanges(); //sil
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {

            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);

               
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext()) 
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();

                        // select *from table yap list ekle
            }
        }

        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updateEntity = context.Entry(entity); //db git ekleme yap
                updateEntity.State = EntityState.Modified;  //silinecek nesne
                context.SaveChanges(); //sil
            }

        }
    }
}
