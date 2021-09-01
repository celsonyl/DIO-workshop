using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_workshop.Entities
{
    class User
    {
        private int Id {get; set; }
        private String Name { get; set; }
        private String Cpf { get; set; }
        private Double Saldo { get; set; }
        private List<Product> List = new List<Product>();

        public User() { }

        public User(int id, string name, string cpf, double saldo)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Saldo = saldo;
        }

        public Double AdicionarSaldo(Double saldo)
        {
            return Saldo += saldo;
        }

        public override string ToString()
        {
            var imprime = "";
            Console.WriteLine();
            imprime += "ID:" + Id + Environment.NewLine;
            imprime += "Nome: " + Name + Environment.NewLine;
            imprime += "CPF: " + Cpf + Environment.NewLine;
            imprime += "Saldo: " + Saldo + Environment.NewLine;
            imprime += "Produtos:" + Environment.NewLine;
            foreach (var obj in List)
            {
                imprime += obj.ToString();
            }
            return imprime;
        }

        public String RetornaNome()
        {
            return Name;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool comprarProduto(Product obj)
        {
            Saldo -= obj.price();
            if(Saldo < 0)
            {
                return false;
            }
            List.Add(obj);
            return true;
        }
    }
}
