using coursAsp_ActivitePart3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coursAsp_ActivitePart3.Controllers
{
    public class LivreController : Controller
    {
        // GET: Livre
        public ActionResult AfficherTousLesLivres()
        {
            Dal Dal = new Dal();
            ViewData["Livres"] = Dal.GetAllLivres();
            return View("ListeLivres");
        }

        public ActionResult AfficherLivreParId(int idLivre)
        {
            Dal Dal = new Dal();
            ViewData["Livre"] = Dal.GetLivreById(idLivre);
            ViewData["Emprunteur"] = Dal.GetEmprunteurByIdLivre(idLivre);
            return View("AfficherLivre");
        }

    }
}