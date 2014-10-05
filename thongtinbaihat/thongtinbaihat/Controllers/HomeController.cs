using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thongtinbaihat.Models;

namespace thongtinbaihat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Search(string q)
        {
            var db = new SongsInfoContext();
            var songs = from a in db.Songs
                               .Where(a => a.SongName.Contains(q))
                        select a;

            return View(songs);
        }

        public ActionResult QuickSearch(string term)
        {
            var songs = GetSongs(term).Select(a => new { value = a.SongName });
            return Json(songs, JsonRequestBehavior.AllowGet);
        }

        private List<SongsInfo> GetSongs(string searchString)
        {
            var db = new SongsInfoContext();
            return db.Songs.Include("Artist")
                    .Where(a => a.SongName.Contains(searchString))
                    .ToList();
        }

        public ActionResult AlbumSearch(string q)
        {
            var songs = GetSongs(q);
            return Json(songs, JsonRequestBehavior.AllowGet);
        }
    }
}
