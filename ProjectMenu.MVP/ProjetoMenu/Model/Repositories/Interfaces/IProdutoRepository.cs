using ProjetoMenu.Model.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoMenu.Model.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto GetById(int id);
        void Add(Produto obj);
        void Edit(Produto obj);
        void Delete(Produto obj);
        void Save();
    }
}
