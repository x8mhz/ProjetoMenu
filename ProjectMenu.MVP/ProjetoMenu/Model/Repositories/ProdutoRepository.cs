using ProjetoMenu.Model.Data.Context;
using ProjetoMenu.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProjetoMenu.Model.Repositories
{
    public class ProdutoRepository
    {
        private ProjetoMenuContext _db = new ProjetoMenuContext();

        public void Add(Produto obj)
        {
            _db.Set<Produto>().Add(obj);
        }

        public void Delete(Produto obj)
        {
            _db.Set<Produto>().Remove(obj);
        }

        public void Edit(Produto obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _db.Set<Produto>();
        }

        public Produto GetById(int id)
        {
            return _db.Set<Produto>().Find(id);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
