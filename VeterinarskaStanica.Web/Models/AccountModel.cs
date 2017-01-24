using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VeterinarskaStanica.Web.Models
{
    public class AccountModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Korisnicko ime")]
        public virtual string KorisnickoIme { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public virtual string Lozinka { get; set; }
    }
}