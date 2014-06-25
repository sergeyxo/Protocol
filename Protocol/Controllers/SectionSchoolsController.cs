using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Protocol.Models;

namespace Protocol.Controllers
{
    public class SectionSchoolsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /SectionSchools/
        public ActionResult Index()
        {
            return View(db.SectionSchools.ToList());
        }

        // GET: /SectionSchools/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectionSchools sectionschools = db.SectionSchools.Find(id);
            if (sectionschools == null)
            {
                return HttpNotFound();
            }
            return View(sectionschools);
        }

        // GET: /SectionSchools/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /SectionSchools/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,ParenId,CreatedDate,UserCreated,LastModified,UserModified")] SectionSchools sectionschools)
        {
            if (ModelState.IsValid)
            {
                db.SectionSchools.Add(sectionschools);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sectionschools);
        }

        // GET: /SectionSchools/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectionSchools sectionschools = db.SectionSchools.Find(id);
            if (sectionschools == null)
            {
                return HttpNotFound();
            }
            return View(sectionschools);
        }

        // POST: /SectionSchools/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,ParenId,CreatedDate,UserCreated,LastModified,UserModified")] SectionSchools sectionschools)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sectionschools).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sectionschools);
        }

        // GET: /SectionSchools/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectionSchools sectionschools = db.SectionSchools.Find(id);
            if (sectionschools == null)
            {
                return HttpNotFound();
            }
            return View(sectionschools);
        }

        // POST: /SectionSchools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SectionSchools sectionschools = db.SectionSchools.Find(id);
            db.SectionSchools.Remove(sectionschools);
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
