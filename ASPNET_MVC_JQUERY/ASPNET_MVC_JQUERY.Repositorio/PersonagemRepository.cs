using ASPNET_MVC_JQUERY.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_MVC_JQUERY.Repositorio
{
    public class PersonagemRepository : IRepositoryBase<IPersonagem>
    {
        public List<IPersonagem> Lista { get; set; }
        
        private PersonagemRepository() {
            
        }
        
        public static PersonagemRepository getInstance()
        {
            return new PersonagemRepository();
        }

        public int Inserir(IPersonagem entrada)
        {
            entrada.IdPersonagem = Lista.Last<IPersonagem>().IdPersonagem + 1;
            Lista.Add(entrada);
            return entrada.IdPersonagem;
        }

        public bool Alterar(IPersonagem entrada)
        {
            IPersonagem personagemPesquisado = Buscar(entrada.IdPersonagem);
            Ajudante.CopyPropertiesTo<IPersonagem, IPersonagem>(entrada, personagemPesquisado);
            return true;
        }

        public bool Excluir(IPersonagem entrada)
        {
            //Verificar
            if (Lista.RemoveAll(x => x.IdPersonagem == entrada.IdPersonagem) > 0)
            {
                return true;
            }
            return false;
        }

        public IPersonagem Buscar(int codigo)
        {
            return Lista.FirstOrDefault(x => x.IdPersonagem == codigo);
        }

        public IEnumerable<IPersonagem> ListarTodos()
        {
            return Lista;
        }
    }
}
