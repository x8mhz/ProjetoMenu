using ProjetoMenu.Model.Entities;
using ProjetoMenu.Model.Repositories.Interfaces;
using ProjetoMenu.View.Interfaces;

namespace ProjetoMenu.Presenter
{
    public class AddProductPresenter
    {
        private IAddProductView _addView;
        private IProductRepository _repository;

        public AddProductPresenter(IAddProductView addView, IProductRepository repository)
        {
            _addView = addView;
            _repository = repository;
        }

        public void AddProduct()
        {
             var product = new Product (_addView.Brand, _addView.Model, _addView.Description, _addView.Amount, _addView.Price );
            _repository.Add(product);
            _repository.Save();
        }
    }
}
