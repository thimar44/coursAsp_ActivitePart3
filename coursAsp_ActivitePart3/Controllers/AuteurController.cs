using coursAsp_ActivitePart3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coursAsp_ActivitePart3.Controllers
{
    public class AuteurController : Controller
    {
        // GET: Auteur
        public ActionResult AfficherTousLesAuteurs()
        {
            Dal Dal = new Dal();
            ViewData["Auteurs"] = Dal.GetAllAuteurs();
            return View("ListeAuteurs");
        }

        
        public ActionResult AfficherLivreParAuteur(int idAuteur)
        {
            Console.WriteLine("idAuteur : " + idAuteur);
            Dal Dal = new Dal();
            Auteur auteur = Dal.GetAuteurById(idAuteur);   
            ViewData["AuteurNom"] = auteur.Nom;
            ViewData["Livres"] = Dal.GetLivreByAuteur(auteur);
            return View("ListeParAuteur");
        }
    }
}