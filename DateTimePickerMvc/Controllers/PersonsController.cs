using DateTimePickerMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateTimePickerMvc.Controllers
{    
    public class PersonsController : Controller
    {
        private PersonContext db = new PersonContext();

        public ActionResult Index()
        {
            return View(db.Persons);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}
