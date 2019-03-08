using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class fileInfoesController : Controller
    {
        private V1Entities db = new V1Entities();

        // GET: fileInfoes
        public ActionResult Index()
        {
            var fileInfoes = db.fileInfoes.Include(f => f.volume);
            return View(fileInfoes.ToList());
        }

        // GET: fileInfoes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fileInfo fileInfo = db.fileInfoes.Find(id);
            if (fileInfo == null)
            {
                return HttpNotFound();
            }
            return View(fileInfo);
        }

        // GET: fileInfoes/Create
        public ActionResult Create()
        {
            ViewBag.volID = new SelectList(db.volumes, "volID", "volumeName");
            return View();
        }

        // POST: fileInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FID,volID,pciFlag,piiFlag,specFlag,retFlag,unknownFlag,publicFlag,internalFlag,confidentialFlag,confidentialsFlag,secretFlag")] fileInfo fileInfo)
        {
            if (ModelState.IsValid)
            {
                db.fileInfoes.Add(fileInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.volID = new SelectList(db.volumes, "volID", "volumeName", fileInfo.volID);
            return View(fileInfo);
        }

        // GET: fileInfoes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fileInfo fileInfo = db.fileInfoes.Find(id);
            if (fileInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.volID = new SelectList(db.volumes, "volID", "volumeName", fileInfo.volID);
            return View(fileInfo);
        }

        // POST: fileInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FID,volID,pciFlag,piiFlag,specFlag,retFlag,unknownFlag,publicFlag,internalFlag,confidentialFlag,confidentialsFlag,secretFlag")] fileInfo fileInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fileInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.volID = new SelectList(db.volumes, "volID", "volumeName", fileInfo.volID);
            return View(fileInfo);
        }

        // GET: fileInfoes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fileInfo fileInfo = db.fileInfoes.Find(id);
            if (fileInfo == null)
            {
                return HttpNotFound();
            }
            return View(fileInfo);
        }

        // POST: fileInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            fileInfo fileInfo = db.fileInfoes.Find(id);
            db.fileInfoes.Remove(fileInfo);
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
