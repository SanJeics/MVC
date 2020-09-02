using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        List<ArtistCLS> ListaArtist = null;
        public ActionResult Index()
        {
            using (var db = new musicmanEntities())
            {
                ListaArtist = (from i in db.Artist
                               select new ArtistCLS
                               {
                                   Name = i.Name,
                               }).ToList();

            }
            return View(ListaArtist);
        }
    }
}
