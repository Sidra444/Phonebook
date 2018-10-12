using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhoneBook.Models;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {

            PhoneBookDbEntities db = new PhoneBookDbEntities();
            List<Contact> list = db.Contacts.ToList();
            List<ContactViewModel> viewlist = new List<ContactViewModel>();
            foreach (Contact c in list)
            {
                ContactViewModel obj = new ContactViewModel();
                obj.ContactId = c.ContactId;
                obj.ContactNumber = c.ContactNumber;
                obj.Type = c.Type;
                obj.PersonId = c.PersonId;
              
                viewlist.Add(obj);
            }
            return View(viewlist);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(ContactViewModel obj)
        {
            try
            {
                Contact c = new Contact();
                c.ContactId = obj.ContactId;
                c.ContactNumber = obj.ContactNumber;
                c.Type = obj.Type;
                c.PersonId = obj.PersonId;



                using (PhoneBookDbEntities db = new PhoneBookDbEntities())
                {
                    db.Contacts.Add(c);
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

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contacts/Edit/5
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

        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contacts/Delete/5
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
