using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyHousing.DAL;
using MyHousing.Models;

namespace MyHousing.Controllers
{
    public class HouseStatesController : Controller
    {
        private MyHousingContext db = new MyHousingContext();

        // GET: HouseStates
        public ActionResult Index()
        {
            return View(db.HouseStates.ToList());
        }

        // GET: HouseStates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HouseState houseState = db.HouseStates.Find(id);
            if (houseState == null)
            {
                return HttpNotFound();
            }
            return View(houseState);
        }

        // GET: HouseStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HouseStates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HouseStateId,HouseName,HouseType,Postcode,RentRate,MainAddress,Suburb,Region,Description,Bedroom,Bathroom,CarparkOk,PetOk,OnMarktetFlg,Latitude,Longitude")] HouseState houseState)
        {
            if (ModelState.IsValid)
            {
                db.HouseStates.Add(houseState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(houseState);
        }

        // GET: HouseStates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HouseState houseState = db.HouseStates.Find(id);
            if (houseState == null)
            {
                return HttpNotFound();
            }
            return View(houseState);
        }

        // POST: HouseStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HouseStateId,HouseName,HouseType,Postcode,RentRate,MainAddress,Suburb,Region,Description,Bedroom,Bathroom,CarparkOk,PetOk,OnMarktetFlg,Latitude,Longitude")] HouseState houseState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(houseState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(houseState);
        }

        // GET: HouseStates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HouseState houseState = db.HouseStates.Find(id);
            if (houseState == null)
            {
                return HttpNotFound();
            }
            return View(houseState);
        }

        // POST: HouseStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HouseState houseState = db.HouseStates.Find(id);
            db.HouseStates.Remove(houseState);
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
