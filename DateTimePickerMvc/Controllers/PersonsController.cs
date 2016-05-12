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

            else if (person.Name.Length <= 2)
            {
                ModelState.AddModelError("State", "Недопустимая длина строки для поля 'Имя'");
            }

          
            return View(person);
        }

        /// <summary>
        /// проверка страны введенной польззователем 
        /// для простоты эксперемента - мы просто сравникаем введенное пользователем название 
        /// со  значениями которые хранятся в массиве 
        /// </summary>
        /// <param name="State"></param>
        /// <returns></returns>
        public JsonResult CheckCountry(string State)
        {
            var countries = new[] { "Армения", "Азербайджан", "Белоруссия", " Казахстан", "Киргизия", "Молдавия", "Россия", "Таджикистан", "Туркмения", "Узбекистан", "Украина" };

            // TODO: для истории фейковый запрос - вернет индекс найденного элемента массива 
            //var result2 = countries.Select((s, i) => new { i, s })
            //                             .Where(t => t.s == "avg")
            //                             .Select(t => t.i)
            //                             .ToList();

            bool result = countries.Any(State.Contains);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AutocompleteSearch(string term)
        {
            var allCountries = new List<string>() { "Украина", "Беларусь", "Латвия", "Литва" };

            var models = allCountries.Where(a => a.Contains(term))
                   .Select(a => new { value = a })
                   .Distinct();      

            return Json(models, JsonRequestBehavior.AllowGet);
        }
    }
}

