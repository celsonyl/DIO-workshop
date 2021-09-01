using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_workshop.Interfaces
{
    interface Repository<T>
    {
        List<T> ListarDados();
        void InsereUser(T obj);
        void ExcluirUser(int id);
        T EncontraUser(int id);
    }
}
