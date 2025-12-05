using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CatchKeeperMVC.Models;

namespace CatchKeeperMVC.Controllers
{
    public class CatchesController : Controller
    {
        private CatchKeeperContext db = new CatchKeeperContext();

        // GET: Catches
        public ActionResult Index()
        {
            return View(db.Catches.ToList());
        }

        // GET: Catches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catch @catch = db.Catches.Find(id);
            if (@catch == null)
            {
                return HttpNotFound();
            }
            return View(@catch);
        }

        // GET: Catches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CatchDate,Species,LengthInInches,WeightInPounds,BaitUsed,LocationName,Weather,Technique,PhotoUrl,Notes")] Catch @catch)
        {
            if (ModelState.IsValid)
            {
                db.Catches.Add(@catch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@catch);
        }

        // GET: Catches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catch @catch = db.Catches.Find(id);
            if (@catch == null)
            {
                return HttpNotFound();
            }
            return View(@catch);
        }

        // POST: Catches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CatchDate,Species,LengthInInches,WeightInPounds,BaitUsed,LocationName,Weather,Technique,PhotoUrl,Notes")] Catch @catch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@catch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@catch);
        }

        // GET: Catches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Catch @catch = db.Catches.Find(id);
            if (@catch == null)
            {
                return HttpNotFound();
            }
            return View(@catch);
        }

        // POST: Catches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Catch @catch = db.Catches.Find(id);
            db.Catches.Remove(@catch);
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
