namespace ProjetoMenu.View.Interfaces
{
    public interface IAddProductView
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Description { get; set; }
        int Amount { get; set; }
        decimal Price { get; set; }
    }
}
