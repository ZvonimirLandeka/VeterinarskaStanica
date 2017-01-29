using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VeterinarskaStanica.Model
{
    public class VrstaZivotinje : BazniEntitet
    {

        [Display(Name = "Naziv vrste")]
        public virtual  string Naziv { get; set; }

        public VrstaZivotinje(int Id) : base(Id)
        {
        }
        public VrstaZivotinje() : base(-1)
        {
        }
    }
}
