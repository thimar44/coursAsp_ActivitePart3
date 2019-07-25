using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coursAsp_ActivitePart3.Models
{
    public class Dal : IDal
    {

        public static Auteur MickaelConnelly = new Auteur { Id = 1, Nom = "Mickael Connelly" };
        public static Auteur HarlanCoben = new Auteur { Id = 2, Nom = "Harlan Coben" };
        public static Auteur MaximeChattam = new Auteur { Id = 3, Nom = "Maxime Chattam" };

        public static Livre EnAttendantLeJour = 
            new Livre { Id = 1, Titre = "En attendant le jour", DateDeParution = new DateTime(2019, 03, 13), Auteur = MickaelConnelly, EstEmprunte = false};
        public static Livre EchoPark =
            new Livre { Id = 2, Titre = "Echo Park", DateDeParution = new DateTime(2018,11,28), Auteur = MickaelConnelly, EstEmprunte = true};
        public static Livre LeDernierCoyote =
            new Livre { Id = 3, Titre = "Le dernier Coyote", DateDeParution = new DateTime(1995,1,1), Auteur = MickaelConnelly, EstEmprunte = true };
        public static Livre PeurNoire =
           new Livre { Id = 4, Titre = "Peur noire", DateDeParution = new DateTime(2000,3,12), Auteur = HarlanCoben, EstEmprunte = true };
        public static Livre Predateurs =
           new Livre { Id = 5, Titre = "Prédateurs", DateDeParution = new DateTime(2007,4,4), Auteur = MaximeChattam, EstEmprunte = false };

        public static Client JeanClaudeDuss =
            new Client { Email = "jeanclaude.duss@gmail.com", Nom = "Jean-Claude DUSS", LivreEmpruntes = new List<Livre> { PeurNoire } };
        public static Client FrancoisPignon =
            new Client { Email = "francois.pignon@gmail.com", Nom = "François PIGNON", LivreEmpruntes = new List<Livre> { EchoPark, LeDernierCoyote } };
       
        public List<Auteur> GetAllAuteurs()
        {
            return new List<Auteur> { MaximeChattam, MickaelConnelly, HarlanCoben };
        }

        public List<Livre> GetAllLivres()
        {
            return new List<Livre> { EnAttendantLeJour, EchoPark, LeDernierCoyote, PeurNoire, Predateurs };
        }
    }
}