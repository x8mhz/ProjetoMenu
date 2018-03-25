using System;

namespace ProjetoMenu.Model.Entities
{
    public class Produto
    {

        public int Id { get; set; }

        public string Marca { get; set; }

        public string Tipo { get; set; }

        public string Modelo { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor { get; set; }
    }
}
