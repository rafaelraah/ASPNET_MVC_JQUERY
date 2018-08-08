using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET_MVC_JQUERY.Modelo;
using ASPNET_MVC_JQUERY.Models;
using ASPNET_MVC_JQUERY.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_JQUERY.Controllers
{
    public class PersonagemController : Controller
    {
        PersonagemServico _personagemServico;

        public PersonagemController()
        {
            _personagemServico = PersonagemServico.getInstance();
            if (_personagemServico.ListarTodos() == null)
            {
                List<IPersonagem> personagens = new List<IPersonagem>();
                personagens.Add(PersonagemModel.GetInstance(IdPersonagem : 1, Classe : "Arqueiro", Nickname : "rafaelarcher", DataCriacao : DateTime.Now));
                personagens.Add(PersonagemModel.GetInstance(IdPersonagem : 2, Classe : "Bruxo", Nickname : "mickeybruxo", DataCriacao : DateTime.Parse("18/07/2018")));
                personagens.Add(PersonagemModel.GetInstance(IdPersonagem : 3, Classe : "Mago", Nickname : "maguinho", DataCriacao : DateTime.Parse("13/11/2017")));
                personagens.Add(PersonagemModel.GetInstance(IdPersonagem : 4, Classe : "Guerreiro", Nickname : "brunoknight", DataCriacao : DateTime.Parse("04/01/2016")));
                _personagemServico.IniciarPersonagens(personagens);
            }
        }

        // GET: Personagem
        public ActionResult Index()
        {
            return View();
        }

        // GET: Personagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personagem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personagem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personagem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personagem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


         public ActionResult List()
         {
             return PartialView(_personagemServico.ListarTodos());
         }
         

        /*  public async Task<IViewComponentResult> InvokeAsync(
      int maxPriority, bool isDone)
  {
      string MyView = "Default";
      // If asking for all completed tasks, render with the "PVC" view.
      if (maxPriority > 3 && isDone == true)
      {
          MyView = "PVC";
      }
      var items = await GetItemsAsync(maxPriority, isDone);
      return View(MyView, items);
  }
          }*/



    }
}