using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

using ProjetDDD.Domain.Interfaces.Repositories;
using ProjetDDD.Infra.Context;

namespace ProjetDDD.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class 
    {
        protected ProjetDDDContext Db = new ProjetDDDContext();
        public bool Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public TEntity GetById(Int32 id=0)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public bool Update(TEntity obj)
        {

            //var obj = Db.Set<TEntity>().Find(id);
            Db.Entry(obj).State = EntityState.Modified;
            if(Db.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Remove(int id)
        {
            var obj = Db.Set<TEntity>().Find(id);
            //Db.Entry(obj2).State = EntityState.Deleted;
            Db.Set<TEntity>().Remove(obj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
