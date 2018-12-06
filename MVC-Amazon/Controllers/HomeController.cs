using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Amazon.Models;
using MVC_Amazon.Models.Extensions;

namespace MVC_Amazon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {

            //return "Hola nariz de bola";
            int hour = DateTime.Now.Hour;
            ViewBag.Saludos = hour < 12 ? "Buenos dias" : "Buenas tardes";
            Repository.FillBooks();
            return View("Index");
        }

        [HttpGet]
        public ViewResult RegBookForm()
        {
            return View();
        }

        [HttpPost]
        // Se agrega un 
        public ViewResult RegBookForm(BookResponse bookResponse)
        {
            // TODO: store reponse from visitor
            //Repository.AddResponse(bookResponse);
            //return View("Thanks", bookResponse); // el nombre del formulario es "gracias" que hara de base de datos temporal

            // Agregamos una validacion
            if (ModelState.IsValid)
            {
                Repository.AddResponse(bookResponse);
                return View("Thanks", bookResponse);
            }
            else
            {
                // Hay un error de validación y retornamos una vista en blanco.
                return View();
            }
        }

        [HttpGet]
        public ViewResult ListResponses()
        {
            //return View(Repository.Responses.Where(b => b.Price > 100)); Libros caros
            //return View(Repository.Responses.Where(b => b.Price < 100)); Libros baratos
            // cuando no se dice que vista, entonces por defecto busca la vista listResponses.cshtml
            ViewBag.TotalPrice = Repository.TotalPrice();
            return View(Repository.Responses);
        }

    }
}
