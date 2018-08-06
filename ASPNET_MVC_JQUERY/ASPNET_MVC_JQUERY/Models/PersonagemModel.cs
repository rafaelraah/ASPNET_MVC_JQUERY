using ASPNET_MVC_JQUERY.Modelo;
using System;

namespace ASPNET_MVC_JQUERY.Models
{
    public class PersonagemModel : IPersonagem
    {
        public int IdPersonagem { get; set; }
        public string Nickname { get; set; }
        public string Classe { get; set; }
        public DateTime DataCriacao { get; set; }

        public PersonagemModel()
        {

        }

        private PersonagemModel(int idPersonagem, string nickname, string classe, DateTime dataCriacao)
        {
            IdPersonagem = idPersonagem;
            Nickname = nickname;
            Classe = classe;
            DataCriacao = dataCriacao;
        }

        public static IPersonagem GetInstance(int IdPersonagem, string Nickname, string Classe, DateTime DataCriacao)
        {
            return new PersonagemModel(IdPersonagem, Nickname, Classe, DataCriacao);
        }
    }
}
