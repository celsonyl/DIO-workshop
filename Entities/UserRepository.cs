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

        public void AtualizarDados(User obj)
        {
            throw new NotImplementedException();
        }

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
    }
}
