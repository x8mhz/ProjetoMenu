using ProjetoMenu.Model.Entities;
using ProjetoMenu.Model.Repositories;
using ProjetoMenu.Model.Repositories.Interfaces;
using ProjetoMenu.View.Interfaces;

namespace ProjetoMenu.Presenter
{
    public class ProdutoPresenter
    {
        private IProdutoView _view;
        private ProdutoRepository _repository;

        public ProdutoPresenter(IProdutoView view)
        {
            _view = view;
        }

        public void Adicionar()
        {
            _repository = new ProdutoRepository();
            var produto = new Produto { Marca = _view.Marca, Modelo = _view.Modelo, Tipo = _view.Tipo, Quantidade = _view.Quantidade, Valor = _view.Valor };
            _repository.Add(produto);
            _repository.Save();
        }
    }
}
