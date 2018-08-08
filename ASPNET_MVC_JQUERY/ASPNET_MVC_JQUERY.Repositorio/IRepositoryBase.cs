using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_MVC_JQUERY.Repositorio
{
    public interface IRepositoryBase <T>
    {
        int Inserir(T entrada);
        bool Alterar(T entrada);
        bool Excluir(T entrada);
        T Buscar(int codigo);
        IEnumerable<T> ListarTodos();
    }
}
