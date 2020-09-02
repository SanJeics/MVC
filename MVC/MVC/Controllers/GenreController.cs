using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre
        List<GenreCLS> ListaGenre= null;
        public ActionResult Index()
        {
            using (var db = new musicmanEntities())
            {
                ListaGenre = (from i in db.Genre
                              select new GenreCLS
                               {
                                   Name = i.name,
                               }).ToList();

            }
            return View(ListaGenre);
        }
    }
}
