using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContactsCrudMvc.Web.Models;

namespace ContactsCrudMvc.Web.Controllers
{
    public class PeopleController : Controller
    {
        private ContactsCrudMvcWebContext db = new ContactsCrudMvcWebContext();

        // GET: People
        public ActionResult Index()
        {
            return View(db.Personcs.ToList());
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personcs personcs = db.Personcs.Find(id);
            if (personcs == null)
            {
                return HttpNotFound();
            }
            return View(personcs);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Email")] Personcs personcs)
        {
            if (ModelState.IsValid)
            {
                db.Personcs.Add(personcs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personcs);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personcs personcs = db.Personcs.Find(id);
            if (personcs == null)
            {
                return HttpNotFound();
            }
            return View(personcs);
        }

        // POST: People/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email")] Personcs personcs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personcs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personcs);
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personcs personcs = db.Personcs.Find(id);
            if (personcs == null)
            {
                return HttpNotFound();
            }
            return View(personcs);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personcs personcs = db.Personcs.Find(id);
            db.Personcs.Remove(personcs);
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
