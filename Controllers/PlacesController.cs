using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jc279115_MIS4200.DAL;
using jc279115_MIS4200.Models;

namespace jc279115_MIS4200.Controllers
{
    public class PlacesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Places
        public ActionResult Index()
        {
            return View(db.Places.ToList());
        }

        // GET: Places/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Places places = db.Places.Find(id);
            if (places == null)
            {
                return HttpNotFound();
            }
            return View(places);
        }

        // GET: Places/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Places/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "placesID,fullName,address,phoneNumber")] Places places)
        {
            if (ModelState.IsValid)
            {
                db.Places.Add(places);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(places);
        }

        // GET: Places/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Places places = db.Places.Find(id);
            if (places == null)
            {
                return HttpNotFound();
            }
            return View(places);
        }

        // POST: Places/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "placesID,fullName,address,phoneNumber")] Places places)
        {
            if (ModelState.IsValid)
            {
                db.Entry(places).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(places);
        }

        // GET: Places/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Places places = db.Places.Find(id);
            if (places == null)
            {
                return HttpNotFound();
            }
            return View(places);
        }

        // POST: Places/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Places places = db.Places.Find(id);
            db.Places.Remove(places);
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
