using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursAsp_ActivitePart3.Models
{
    interface IDal
    {
        List<Livre> GetAllLivres();
        List<Auteur> GetAllAuteurs();
        Auteur GetAuteurById(int idAuteur);
        List<Livre> GetLivreByAuteur(Auteur auteur);
        Livre GetLivreById(int idLivre);
        Client GetEmprunteurByIdLivre(int idLivre);
        List<Livre> SearchByAuteur(string input);
        List<Livre> SearchByNom(string input);
        List<Livre> SearchByNomAndAuteur(string input);

    }
}
