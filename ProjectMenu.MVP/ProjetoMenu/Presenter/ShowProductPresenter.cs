using ProjetoMenu.Model.Repositories.Interfaces;
using ProjetoMenu.View.Interfaces;

namespace ProjetoMenu.Presenter
{
    public class ShowProductPresenter
    {
        private IShowProductView _showView;
        private IProductRepository _repository;

        public ShowProductPresenter(IShowProductView showView, IProductRepository repository)
        {
            _showView = showView;
            _repository = repository;

           ShowProduct();
        }

        public void ShowProduct()
        {
            var products = _repository.GetAll();
            _showView.LoadProduct(products);
        }
    }
}
