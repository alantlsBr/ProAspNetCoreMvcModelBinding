using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAspNetCoreMvcModelBinding.Models;
using ProAspNetCoreMvcModelBinding.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProAspNetCoreMvcModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index(int id)
        {
            return View("Index", repository[id]);
        }

        public ViewResult Index2(int id)
        {
            return View("Index", repository[id] ?? repository.Pessoa.First());
        }

        public IActionResult Index3(int? id)
        {
            Pessoa pessoa;
            if(id.HasValue && (pessoa = repository[id.Value]) != null)
            {
                return View(pessoa);
            }
            else
            {
                return NotFound();
            }
        }

        public ViewResult Cadastro()
        {
            return View("Cadastro", new Pessoa());
        }

        [HttpPost]
        public ViewResult Cadastro(Pessoa pessoa)
        {
            return View("Index", pessoa);
        }
    }
}
