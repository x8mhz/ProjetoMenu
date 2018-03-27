using ProjetoMenu.Model.Data.Context;
using ProjetoMenu.Model.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoMenu.Model.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ProjectMenuContext _db;

        public RepositoryBase()
        {
            _db = new ProjectMenuContext();
        }

        public void Add(T obj)
        {
            _db.Set<T>().Add(obj);
        }

        public void Delete(T obj)
        {
            _db.Set<T>().Remove(obj);
        }

        public void Edit(T obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();       
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
