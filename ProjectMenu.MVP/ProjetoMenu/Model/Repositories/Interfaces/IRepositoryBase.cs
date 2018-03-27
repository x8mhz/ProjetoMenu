using System;
using System.Collections.Generic;

namespace ProjetoMenu.Model.Repositories.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Edit(T obj);
        void Delete(T obj);
        void Save();
    }
}
