using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace coursAsp_ActivitePart3.Models
{
    public class Client
    {
        [Key]
        public string Email { get; set; }
        public string Nom { get; set; }
       
        public List<Livre> LivreEmpruntes { get; set; }

    }
}