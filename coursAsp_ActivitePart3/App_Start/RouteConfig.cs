using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace coursAsp_ActivitePart3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AfficherTousLesLivres",
                url: "Afficher",
                defaults: new { controller = "Livre", action = "AfficherTousLesLivres" }
            );

            routes.MapRoute(
                name: "AfficherTousLesAuteurs",
                url: "Afficher/Auteurs",
                defaults: new { controller = "Auteur", action = "AfficherTousLesAuteurs" }
            );

            routes.MapRoute(
                name: "AfficherLivreParAuteur",
                url: "Afficher/Auteur/{idAuteur}",
                defaults: new { controller = "Auteur", action = "AfficherLivreParAuteur", idAuteur = 0 }
            );

            routes.MapRoute(
                name: "AfficherLivreParId",
                url: "Afficher/Livre/{idLivre}",
                defaults: new { controller = "Livre", action = "AfficherLivreParId", idLivre = 0 }
            );

            routes.MapRoute(
                name: "RechercherLivre",
                url: "Rechercher/Livre/{input}",
                defaults: new { controller = "Rechercher", action = "RechercherLivre" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
