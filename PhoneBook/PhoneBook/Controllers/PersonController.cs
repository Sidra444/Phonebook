using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneBook.Models;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            List<Person> list = db.People.ToList();
            List<PersonViewModel> viewlist = new List<PersonViewModel>();
            foreach (Person p in list)
            {
                PersonViewModel obj = new PersonViewModel();
                obj.PersonId= p.PersonId;
                obj.FirstName = p.FirstName;
                obj.MiddleName = p.MiddleName;
                obj.LastName = p.LastName;
                obj.DateOfBirth = p.DateOfBirth;
                obj.AddedOn = p.AddedOn;
                obj.AddedBy = p.AddedBy;
                obj.HomeAddress = p.HomeAddress;
                obj.HomeCity = p.HomeCity;
                obj.FaceBookAccountId = p.FaceBookAccountId;
                obj.TwitterId = p.TwitterId;
                obj.LinkedInId = p.LinkedInId;
                obj.ImagePath = p.ImagePath;
                obj.EmailId = p.EmailId;
                viewlist.Add(obj);
            }
            return View(viewlist);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonViewModel obj)
        {
            try
            {
                
                Person p = new Person();
                p.FirstName = obj.FirstName;
                p.MiddleName = obj.MiddleName;
                p.LastName = obj.LastName;
                p.DateOfBirth = obj.DateOfBirth;
                p.AddedOn = obj.AddedOn;
                p.AddedBy = obj.AddedBy;
                p.HomeAddress = obj.HomeAddress;
                p.HomeCity = obj.HomeCity;
                p.FaceBookAccountId = obj.FaceBookAccountId;
                p.LinkedInId = obj.LinkedInId;
                p.UpdateOn = obj.UpdateOn;
                p.ImagePath = obj.ImagePath;
                p.TwitterId = obj.TwitterId;
                p.EmailId = obj.EmailId;

                using (PhoneBookDbEntities db = new PhoneBookDbEntities())
                {
                    db.People.Add(p);
                    db.SaveChanges();
                }
                    // TODO: Add insert logic here
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
