using MvcBasics.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasics.Controllers
{

    public class HomeController : Controller
    {
        //Parameter in einer Aktionsmethode dienen dazu,
        //Daten zu empfangen - die Daten kommen aus dem Request
        //(je nachdem, entweder aus der URL (bei GET), oder aus dem Body (bei POST)
        [HttpGet]
        public ActionResult Index(string username)
        {
            IndexVm modelObjekt = new IndexVm();
            modelObjekt.HeutigerTag = DateTime.Now.DayOfWeek.ToString();
            modelObjekt.Benutzername = username;

            //Zum Rendern der View wird ein Objekt des View-Models mitgeliefert
            return View(modelObjekt);
        }

        [HttpPost] //Diese Attribute schränken ein, welche HTTP Methode von der Aktionsmethode akzeptiert wird
        //public ActionResult ZweiterIndex(string username, int? lieblingszahl)
        public ActionResult ZweiterIndex(IndexPostModel postModel)
        {
            IndexVm modelObjekt = new IndexVm();
            modelObjekt.HeutigerTag = DateTime.Now.DayOfWeek.ToString();
            modelObjekt.Benutzername = postModel.Username;
            modelObjekt.Lieblingszahl = postModel.Lieblingszahl ?? -1;

            //Zum Rendern der View wird ein Objekt des View-Models mitgeliefert
            return View("Index", modelObjekt);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}