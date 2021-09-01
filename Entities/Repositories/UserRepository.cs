using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_workshop.Interfaces;

namespace DIO_workshop.Entities
{
    class UserRepository : Repository<User>
    {
        List<User> user = new List<User>();
        List<Product> producs = new List<Product>();

        public User EncontraUser(int id)
        {
            return user[id];
        }
        
        public void ExcluirUser(int id)
        {
            user = user.Where(x => x.RetornaId() != id).ToList();
        }

        public void InsereUser(User obj)
        {
            user.Add(obj);
        }

        public List<User> ListarDados()
        {
            return user;
        }
        
        public List<Product> mostrarProdutos()
        {
            return producs;
        }

        public void criaProduto()
        {
            producs.Add(new Product(0, "Mouse", 300));
            producs.Add(new Product(1, "Bolsa", 500));
            producs.Add(new Product(2, "Cadeira", 100));
            producs.Add(new Product(3, "Ventilador de teto", 800));
            producs.Add(new Product(4, "Celular", 1300));
            producs.Add(new Product(5, "Fone de ouvido", 50));
        }
        public Product retornaProduto(int id)
        {
            return producs[id];
        }
        
        public void adicionaProdutoAoUsuario(int id)
        {

        }
    }
}
