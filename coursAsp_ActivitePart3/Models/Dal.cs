using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace coursAsp_ActivitePart3.Models
{
    public class Dal : IDal
    {


        public Auteur MickaelConnelly;
        public Auteur HarlanCoben;
        public Auteur MaximeChattam;

        public Livre EnAttendantLeJour;
        public Livre EchoPark;
        public Livre PeurNoire;
        public Livre LeDernierCoyote;
        public Livre Predateurs;

        public Client JeanClaudeDuss;
        public Client FrancoisPignon;
       
        public Dal()
        {
            // Auteurs
            MickaelConnelly = new Auteur { Id = 1, Nom = "Mickael Connelly" };
            HarlanCoben = new Auteur { Id = 2, Nom = "Harlan Coben" };
            MaximeChattam = new Auteur { Id = 3, Nom = "Maxime Chattam" };
            // Livres
            EnAttendantLeJour = new Livre {
                Id = 1, Titre = "En attendant le jour",
                DateDeParution = new DateTime(2019, 03, 13),
                Auteur = MickaelConnelly,
                EstEmprunte = false };
            EchoPark = new Livre {
                Id = 2,
                Titre = "Echo Park",
                DateDeParution = new DateTime(2018, 11, 28),
                Auteur = MickaelConnelly,
                EstEmprunte = true };
            LeDernierCoyote = new Livre {
                Id = 3,
                Titre = "Le dernier Coyote",
                DateDeParution = new DateTime(1995, 1, 1),
                Auteur = MickaelConnelly,
                EstEmprunte = true };
            PeurNoire = new Livre {
                Id = 4,
                Titre = "Peur noire",
                DateDeParution = new DateTime(2000, 3, 12),
                Auteur = HarlanCoben,
                EstEmprunte = true };
            Predateurs = new Livre {
                Id = 5, Titre = "Prédateurs",
                DateDeParution = new DateTime(2007, 4, 4),
                Auteur = MaximeChattam,
                EstEmprunte = false };
            // Clients
            JeanClaudeDuss = new Client {
                Email = "jeanclaude.duss@gmail.com",
                Nom = "Jean-Claude DUSS",
                LivreEmpruntes = new List<Livre> { PeurNoire } };
            FrancoisPignon = new Client {
                Email = "francois.pignon@gmail.com",
                Nom = "François PIGNON",
                LivreEmpruntes = new List<Livre> { EchoPark, LeDernierCoyote } };
    }


        public List<Auteur> GetAllAuteurs()
        {
            return new List<Auteur> { MaximeChattam, MickaelConnelly, HarlanCoben };
        }

        public List<Livre> GetAllLivres()
        {
            return new List<Livre> { EnAttendantLeJour, EchoPark, LeDernierCoyote, PeurNoire, Predateurs };
        }
        public List<Client> GetAllClients()
        {
            return new List<Client> { JeanClaudeDuss, FrancoisPignon };
        }
        public Auteur GetAuteurById(int idAuteur)
        {
            List<Auteur> Auteurs = GetAllAuteurs();
            return Auteurs.Find(a => a.Id == idAuteur);
        }

        public List<Livre> GetLivreByAuteur(Auteur auteur)
        {
            List<Livre> Livres = GetAllLivres();
            return Livres.FindAll(l => l.Auteur.Id == auteur.Id);
        }

        public Livre GetLivreById(int idLivre)
        {
            List<Livre> Livres = GetAllLivres();
            return Livres.Find(l => l.Id == idLivre);
        }

        public Client GetEmprunteurByIdLivre(int idLivre)
        {
            List<Client> Clients = GetAllClients();
            foreach (Client Client in Clients)
            {
                if (Client.LivreEmpruntes.Exists(l => l.Id == idLivre))
                {
                    return Client;
                }
            }

            return null;
        }

        public List<Livre> SearchByAuteur(string input)
        {
            List<Livre> Results = new List<Livre>();
            List<Auteur> AllAuteurs = GetAllAuteurs();
            List<Auteur> AuteursThatMatches = AllAuteurs.FindAll(a => a.Nom.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0);

            if (AuteursThatMatches != null)
            {
                foreach (Auteur auteur in AuteursThatMatches)
                {
                    List<Livre> ResultsGetLivreByAuteur = GetLivreByAuteur(auteur);
                    if (ResultsGetLivreByAuteur != null && ResultsGetLivreByAuteur.Any())
                    {
                        Results = Results.Concat(ResultsGetLivreByAuteur).ToList();
                    }
                }
            } 

            return Results;
        }
        public List<Livre> SearchByNom(string input)
        {
            List<Livre> allLivres = GetAllLivres();
            List<Livre> LivresThatMatches = allLivres.FindAll(l => l.Titre.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0);
            if (LivresThatMatches == null)
            {
                return new List<Livre>();
            }
            return LivresThatMatches;
        }
        public List<Livre> SearchByNomAndAuteur(string input)
        {
            List<Livre> ResultsSearchByNom = SearchByNom(input);
            List<Livre> ResultsSearchByAuteur = SearchByAuteur(input);
            return ResultsSearchByNom.Concat(ResultsSearchByAuteur).ToList().Distinct().ToList();
        }
    }
}