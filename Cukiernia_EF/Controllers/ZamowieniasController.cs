using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cukiernia_EF.Models;

namespace Cukiernia_EF.Controllers
{
    public class ZamowieniasController : Controller
    {
        private CukierniaDbContext db = new CukierniaDbContext();

        // GET: Zamowienias
        public ActionResult Index()
        {
            var zamowienia = db.Zamowienia.Include(z => z.Klient);
            return View(zamowienia.ToList());
        }

        // GET: Zamowienias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zamowienia zamowienia = db.Zamowienia.Find(id);
            if (zamowienia == null)
            {
                return HttpNotFound();
            }
            return View(zamowienia);
        }

        // GET: Zamowienias/Create
        public ActionResult Create()
        {
            ViewBag.KlientID = new SelectList(db.Klienci, "KlienciId", "NazwaFirmy");
            return View();
        }

        // POST: Zamowienias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZamowieniaID,KlientID,WartoscZamowienia,DataZamowienia,DataRealizacji,Znizka")] Zamowienia zamowienia)
        {
            if (ModelState.IsValid)
            {
                db.Zamowienia.Add(zamowienia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KlientID = new SelectList(db.Klienci, "KlienciId", "NazwaFirmy", zamowienia.KlientID);
            return View(zamowienia);
        }

        // GET: Zamowienias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zamowienia zamowienia = db.Zamowienia.Find(id);
            if (zamowienia == null)
            {
                return HttpNotFound();
            }
            ViewBag.KlientID = new SelectList(db.Klienci, "KlienciId", "NazwaFirmy", zamowienia.KlientID);
            return View(zamowienia);
        }

        // POST: Zamowienias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZamowieniaID,KlientID,WartoscZamowienia,DataZamowienia,DataRealizacji,Znizka")] Zamowienia zamowienia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zamowienia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KlientID = new SelectList(db.Klienci, "KlienciId", "NazwaFirmy", zamowienia.KlientID);
            return View(zamowienia);
        }

        // GET: Zamowienias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zamowienia zamowienia = db.Zamowienia.Find(id);
            if (zamowienia == null)
            {
                return HttpNotFound();
            }
            return View(zamowienia);
        }

        // POST: Zamowienias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zamowienia zamowienia = db.Zamowienia.Find(id);
            db.Zamowienia.Remove(zamowienia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
