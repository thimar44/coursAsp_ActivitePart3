using coursAsp_ActivitePart3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coursAsp_ActivitePart3.Controllers
{
    public class RechercherController : Controller
    {
        // GET: Rechercher
        public ActionResult RechercherLivre(string input)
        {
            Dal Dal = new Dal();
            ViewData["input"] = input;
            ViewData["Livres"] = Dal.SearchByNomAndAuteur(input);
            return View("RechercherLivre");
        }
    }
}