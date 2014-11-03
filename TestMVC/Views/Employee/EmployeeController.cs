using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestMVC.EntityFramework;

namespace TestMVC.Views.Employee
{
    public class EmployeeController : Controller
    {
        private MPPLEntities db = new MPPLEntities();

        // GET: /Employee/
        public ActionResult Index()
        {
            return View(db.hEmployees.ToList().Take(10));
        }

        // GET: /Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hEmployee hemployee = db.hEmployees.Find(id);
            if (hemployee == null)
            {
                return HttpNotFound();
            }
            return View(hemployee);
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EmployeeID,EmployeeNumber,SSN,Badge,EmployerID,LastName,FirstName,MiddleName,Salutation,Status,NickName,PayGroupID,TimeGroupID,WorkCodeCountryID,TimeSheetWorkCodeID,CustomTimeRule,BirthDate,LastHireDate,AdjSeniorityDate,OriginalHireDate,MaritialStatus,SystemValueCodeID,Email,EthnicOrigin,Gender,Disability,Smoker,EffectiveDate,ChangeDate,ReCalculate,Exempt,SeniorityHours")] hEmployee hemployee)
        {
            if (ModelState.IsValid)
            {
                db.hEmployees.Add(hemployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hemployee);
        }

        // GET: /Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hEmployee hemployee = db.hEmployees.Find(id);
            if (hemployee == null)
            {
                return HttpNotFound();
            }
            return View(hemployee);
        }

        // POST: /Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EmployeeID,EmployeeNumber,SSN,Badge,EmployerID,LastName,FirstName,MiddleName,Salutation,Status,NickName,PayGroupID,TimeGroupID,WorkCodeCountryID,TimeSheetWorkCodeID,CustomTimeRule,BirthDate,LastHireDate,AdjSeniorityDate,OriginalHireDate,MaritialStatus,SystemValueCodeID,Email,EthnicOrigin,Gender,Disability,Smoker,EffectiveDate,ChangeDate,ReCalculate,Exempt,SeniorityHours")] hEmployee hemployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hemployee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hemployee);
        }

        // GET: /Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hEmployee hemployee = db.hEmployees.Find(id);
            if (hemployee == null)
            {
                return HttpNotFound();
            }
            return View(hemployee);
        }

        public ActionResult abcd(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hEmployee hemployee = db.hEmployees.Find(id);
            if (hemployee == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Employee/abcde.cshtml", hemployee);
        }


        // POST: /Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult abcd([Bind(Include = "EmployeeID,EmployeeNumber,SSN,Badge,EmployerID,LastName,FirstName,MiddleName,Salutation,Status,NickName,PayGroupID,TimeGroupID,WorkCodeCountryID,TimeSheetWorkCodeID,CustomTimeRule,BirthDate,LastHireDate,AdjSeniorityDate,OriginalHireDate,MaritialStatus,SystemValueCodeID,Email,EthnicOrigin,Gender,Disability,Smoker,EffectiveDate,ChangeDate,ReCalculate,Exempt,SeniorityHours")] hEmployee hemployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hemployee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hemployee);
        }

        public ActionResult efgh([Bind(Include = "EmployeeID,EmployeeNumber,SSN,Badge,EmployerID,LastName,FirstName,MiddleName,Salutation,Status,NickName,PayGroupID,TimeGroupID,WorkCodeCountryID,TimeSheetWorkCodeID,CustomTimeRule,BirthDate,LastHireDate,AdjSeniorityDate,OriginalHireDate,MaritialStatus,SystemValueCodeID,Email,EthnicOrigin,Gender,Disability,Smoker,EffectiveDate,ChangeDate,ReCalculate,Exempt,SeniorityHours")] hEmployee hemployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hemployee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hemployee);
        }

        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hEmployee hemployee = db.hEmployees.Find(id);
            db.hEmployees.Remove(hemployee);
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
