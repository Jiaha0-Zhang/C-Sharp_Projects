using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Table.ToList());          
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Table.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                decimal baseQuote = 50; //Start with a base of $50/month.

                int age = DateTime.Now.Year - table.DateofBirth.Year; //declare and assign the int varible age.
                if (age <= 18) // If the user is 18 or under, add $100 to the monthly total.
                {
                    baseQuote += 100;
                }
                else if (age >= 19 && age <= 25) //If the user is from 19 to 25, add $50 to the monthly total.
                {
                    baseQuote += 50;
                }
                else //If the user is 26 or older, add $25 to the monthly total.
                {
                    baseQuote += 25;
                }

                if(table.CarYear < 2000) //If the car's year is before 2000, add $25 to the monthly total.
                {
                    baseQuote += 25;
                }
                else if(table.CarYear > 2015) //If the car's year is after 2015, add $25 to the monthly total.
                {
                    baseQuote += 25;
                }

                if(table.CarMake.ToLower() == "porsche") //If the car's Make is a Porsche, add $25 to the price.
                {
                    baseQuote += 25;
                    if(table.CarMake.ToLower() == "911 carrera")
                    {  //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                        baseQuote += 25;
                    }
                }

                baseQuote += 10 * table.SpeedingTickets; //Add $10 to the monthly total for every speeding ticket the user has.

                if(table.DUI) //If the user has ever had a DUI, add 25% to the total.
                {
                    baseQuote *= 1.25m;
                }

                if(table.CoverageType) //If it's full coverage, add 50% to the total.
                {
                    baseQuote *= 1.5m;
                }

                table.Quote = Math.Max(0, baseQuote); // Ensure quote is not less than 0.


                db.Table.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Table.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Table.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Table.Find(id);
            db.Table.Remove(table);
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

        public ActionResult Admin() //questionable here.
        {
            return View(db.Table.ToList());
        }
       
    }
}
