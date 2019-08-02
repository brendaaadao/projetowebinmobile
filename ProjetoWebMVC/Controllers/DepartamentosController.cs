using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Recursos Humanos" });
            list.Add(new Departamento { Id = 2, Nome = "Marketing" });
            list.Add(new Departamento { Id = 3, Nome = "Financeiro" });

            return View(list);
        }
    }
}