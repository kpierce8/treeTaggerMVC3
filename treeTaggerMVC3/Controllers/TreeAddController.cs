using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using treeTaggerMVC3.Models;

namespace treeTaggerMVC3.Controllers
{ 
   
    public class TreeAddController : Controller
    {
        private treeOBSEntities db = new treeOBSEntities();

        public TreeAddController() {

    }
        //
        // GET: /TreeAdd/

        [HttpGet]
        public JsonResult GetJson()
        {
            var model = db.treeOBS.First();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetJsonList()
        {
            var model = db.treeOBS.ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public ViewResult Index()
        {
            return View(db.treeOBS.ToList());
        }

        //
        // GET: /TreeAdd/Details/5

        public ViewResult Details(int id)
        {
            treeObservations treeobservations = db.treeOBS.Find(id);
            return View(treeobservations);
        }

        //
        // GET: /TreeAdd/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /TreeAdd/Create

        [HttpPost]
        public ActionResult Create(treeObservations treeobservations)
        {
            if (ModelState.IsValid)
            {
                db.treeOBS.Add(treeobservations);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(treeobservations);
        }
        
        //
        // GET: /TreeAdd/Edit/5
 
        public ActionResult Edit(int id)
        {
            treeObservations treeobservations = db.treeOBS.Find(id);
            return View(treeobservations);
        }

        //
        // POST: /TreeAdd/Edit/5

        [HttpPost]
        public ActionResult Edit(treeObservations treeobservations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treeobservations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(treeobservations);
        }

        //
        // GET: /TreeAdd/Delete/5
 
        public ActionResult Delete(int id)
        {
            treeObservations treeobservations = db.treeOBS.Find(id);
            return View(treeobservations);
        }

        //
        // POST: /TreeAdd/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            treeObservations treeobservations = db.treeOBS.Find(id);
            db.treeOBS.Remove(treeobservations);
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