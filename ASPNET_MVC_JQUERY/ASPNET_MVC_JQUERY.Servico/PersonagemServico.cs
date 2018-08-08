using ASPNET_MVC_JQUERY.Modelo;
using ASPNET_MVC_JQUERY.Repositorio;
using System;
using System.Collections.Generic;

namespace ASPNET_MVC_JQUERY.Servico
{
    public class PersonagemServico
    {
        private PersonagemRepository PersonagemRepo = null;

        private PersonagemServico()
        {
            PersonagemRepo = PersonagemRepository.getInstance();
        }
        
        public static PersonagemServico getInstance()
        {
            return new PersonagemServico();
        }

        public void IniciarPersonagens(List<IPersonagem> personagens)
        {
            if (PersonagemRepo.ListarTodos() == null)
            {
                PersonagemRepository.Lista = new List<IPersonagem>();
                foreach(var personagem in personagens)
                {
                    Inserir(personagem);
                }
            }
        }
        
        public int Inserir(IPersonagem entrada)
        {
            return PersonagemRepo.Inserir(entrada);
        }

        public bool Alterar(IPersonagem entrada)
        {
            return PersonagemRepo.Alterar(entrada);
        }

        public bool Excluir(IPersonagem entrada)
        {
            return PersonagemRepo.Excluir(entrada);
        }

        public IPersonagem Buscar(int codigo)
        {
            return PersonagemRepo.Buscar(codigo);
        }

        public IEnumerable<IPersonagem> ListarTodos()
        {
            return PersonagemRepo.ListarTodos();
        }
    }
}
