using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SodingAssignment;
using SodingAssignment.Models;

namespace SodingAssignment.Controllers
{
    public class SodingTasksController : Controller
    {
        private TaskContext db = new TaskContext();

        // GET: SodingTasks
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: SodingTasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SodingTask sodingTask = db.Students.Find(id);
            if (sodingTask == null)
            {
                return HttpNotFound();
            }
            return View(sodingTask);
        }

        // GET: SodingTasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SodingTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,description,dateCreated,dateUpdated")] SodingTask sodingTask)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(sodingTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sodingTask);
        }

        // GET: SodingTasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SodingTask sodingTask = db.Students.Find(id);
            if (sodingTask == null)
            {
                return HttpNotFound();
            }
            return View(sodingTask);
        }

        // POST: SodingTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,description,dateCreated,dateUpdated")] SodingTask sodingTask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sodingTask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sodingTask);
        }

        // GET: SodingTasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SodingTask sodingTask = db.Students.Find(id);
            if (sodingTask == null)
            {
                return HttpNotFound();
            }
            return View(sodingTask);
        }

        // POST: SodingTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SodingTask sodingTask = db.Students.Find(id);
            db.Students.Remove(sodingTask);
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
