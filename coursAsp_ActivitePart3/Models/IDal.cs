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
    }
}
