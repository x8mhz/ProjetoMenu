
using ProjetoMenu.Presenter;

namespace ProjetoMenu.View.Interfaces
{
    public interface IProdutoView
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string Tipo { get; set; }
        int Quantidade { get; set; }
        decimal Valor { get; set; }
    }
}
