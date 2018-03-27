using ProjetoMenu.Model.Entities;
using System.Collections.Generic;

namespace ProjetoMenu.View.Interfaces
{
    public interface IShowProductView
    {
        void LoadProduct(IEnumerable<Product> products);
    }
}
