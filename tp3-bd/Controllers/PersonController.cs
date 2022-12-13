using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tp3_bd.Models;

namespace tp3_bd.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult all()
        {
            Personal_info p = new Personal_info();
            return View(p.GetAllPerson());
        }

        public ActionResult id(int id)
        {
            Personal_info p = new Personal_info();

            return View(p.GetPerson(id));
        }  
        [HttpGet]
        public ActionResult search()
        {
            ViewBag.notFound = false;
            return View();
        }
        [HttpPost]
        public ActionResult search(Person p)
        {
            Personal_info persInfo = new Personal_info();
            Debug.WriteLine("check"+p.FirstName+ " " + p.Country);
            List<Person> l = persInfo.GetAllPerson();
            foreach ( Person pers in l)
            {
                if (pers.FirstName == p.FirstName && pers.Country == p.Country)
                {
                    return Redirect("~/Person/" + pers.Id);
                }
            }
            ViewBag.notFound = true;

            return View();
        }

    }
}