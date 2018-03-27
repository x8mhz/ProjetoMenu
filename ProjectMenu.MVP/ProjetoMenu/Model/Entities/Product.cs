using System;

namespace ProjetoMenu.Model.Entities
{
    public class Product
    {
        protected Product()
        {

        }

        public Product(string brand, string model, string description, int amount, decimal price)
        {
            Code = Guid.NewGuid();
            Brand = brand;
            Model = model;
            Description = description;
            EntryDate = DateTime.Now.Date;
            Amount = amount;
            Price = price;
 
        }

        public int Id { get; private set; }
        public Guid Code { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Description { get; private set; }
        public DateTime EntryDate { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }
    }
}
