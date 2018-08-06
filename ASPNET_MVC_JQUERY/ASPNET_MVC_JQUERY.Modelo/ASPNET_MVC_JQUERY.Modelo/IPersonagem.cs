using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_MVC_JQUERY.Modelo
{
    public interface IPersonagem
    {
        int IdPersonagem { get; set; }
        string Nickname { get; set; }
        string Classe { get; set; }
        DateTime DataCriacao { get; set; }
       // IPersonagem GetInstance(int IdPersonagem, string Nickname, string Classe, DateTime DataCriacao);
    }
}
