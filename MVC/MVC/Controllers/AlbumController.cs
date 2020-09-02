using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlbumController : Controller
    {
        List<AlbumCLS> ListaAlbum = null;
        // GET: Album
        public ActionResult Index()
        {
            using (var db = new musicmanEntities())
            {
                ListaAlbum = (from i in db.Albums
                               select new AlbumCLS
                               {
                                   AlbumName = i.AlbumName,
                                   DateReleased = (DateTime)i.DateReleased
                               }).ToList();

            }
            return View(ListaAlbum);
        }
    }
}
