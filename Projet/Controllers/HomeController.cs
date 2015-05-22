using Projet.Filters;
using Projet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Projet.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            var date = DateTime.Now.ToString("T");
            ViewBag.Date = date;

            var utils = new List<Utilisateurs>
            {
                new Utilisateurs {prenom = "Jean-Baptiste", nom = "SEGAUD", age = 23, mail = "jeanbaptiste.segaud@epsi.fr" },
                new Utilisateurs {prenom = "Vincent", nom = "GUAJIOTY", age = 22, mail = "vincent.guajioty@epsi.fr" },
                new Utilisateurs {prenom = "Henri", nom = "DAVANTURE", age = 20, mail = "henri.davanture@epsi.fr" },
                new Utilisateurs {prenom = "Julien", nom = "MERION", age = 24, mail = "julien.merion@epsi.fr" },
                new Utilisateurs {prenom = "Xu", nom = "YIXIONG", age = 31, mail = "xu.yixiong@epsi.fr" }
            };
            return View(utils);
        }
    }
}