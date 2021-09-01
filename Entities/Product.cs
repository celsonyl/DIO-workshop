using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_workshop.Entities
{
    class Product
    {
        private int Id { get; set; }
        private String Nome { get; set; }
        private Double Preco { get; set; }

        public Product() { }

        public Product(int id, string nome, double price)
        {
            Id = id;
            Nome = nome;
            Preco = price;
        }

        public Double price()
        {
            return Preco;
        }

        public override string ToString()
        {
            var imprime = "[ ";
            imprime += "Id: " + Id;
            imprime += "| Nome: "+Nome;
            imprime += "| Preço: " + Preco;
            imprime += " ]" + Environment.NewLine;
            return imprime;
        }
    }
}
