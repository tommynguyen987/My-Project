using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thongtinbaihat.Models;

namespace thongtinbaihat.Controllers
{
    public class SongsManagerController : Controller
    {
        private SongsInfoContext db = new SongsInfoContext();

        //
        // GET: /SongsManager/

        public ActionResult Index()
        {
            return View(db.Songs.ToList());
        }

        //
        // GET: /SongsManager/Details/5

        public ActionResult Details(int id = 0)
        {
            SongsInfo songsinfo = db.Songs.Find(id);
            if (songsinfo == null)
            {
                return HttpNotFound();
            }
            return View(songsinfo);
        }

        //
        // GET: /SongsManager/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SongsManager/Create

        [HttpPost]
        public ActionResult Create(SongsInfo songsinfo)
        {
            if (ModelState.IsValid)
            {
                db.Songs.Add(songsinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(songsinfo);
        }

        //
        // GET: /SongsManager/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SongsInfo songsinfo = db.Songs.Find(id);
            if (songsinfo == null)
            {
                return HttpNotFound();
            }
            return View(songsinfo);
        }

        //
        // POST: /SongsManager/Edit/5

        [HttpPost]
        public ActionResult Edit(SongsInfo songsinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(songsinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(songsinfo);
        }

        //
        // GET: /SongsManager/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SongsInfo songsinfo = db.Songs.Find(id);
            if (songsinfo == null)
            {
                return HttpNotFound();
            }
            return View(songsinfo);
        }

        //
        // POST: /SongsManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SongsInfo songsinfo = db.Songs.Find(id);
            db.Songs.Remove(songsinfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}