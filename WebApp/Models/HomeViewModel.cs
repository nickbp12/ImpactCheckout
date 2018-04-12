using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class HomeViewModel
    {
        [Required (ErrorMessage = "Du skal skrive et navn!")]
        public string Navn { get; set; }
        public string Firmanavn { get; set; }
        [Required (ErrorMessage = "Du skal skrive en addresse!")]
        public string Addresse { get; set; }
        [Required (ErrorMessage = "Du skal skrive et postnr!")]
        [Range(2000, 9990, ErrorMessage = "Du skal skrive minimum 4 tal!")]
        public int Postnr { get; set; }
        [Required (ErrorMessage = "Du skal skrive et bynavn!")]
        public string Bynavn { get; set; }
        [Required (ErrorMessage = "Du skal skrive en E-mail!")]
        [EmailAddress (ErrorMessage = "Du skal skrive en E-mail")]
        public string Email { get; set; }
        [Required (ErrorMessage = "Du skal skrive et mobilnr!")]
        [Range (10000000, 99999999, ErrorMessage = "Du skal skrive minimum 8 tal!")]
        public int Mobilnr { get; set; }
    }
}