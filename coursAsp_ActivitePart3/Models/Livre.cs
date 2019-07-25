using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coursAsp_ActivitePart3.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateDeParution { get; set; }
        public Auteur Auteur { get; set; }
        public bool EstEmprunte { get; set; }
    }
}