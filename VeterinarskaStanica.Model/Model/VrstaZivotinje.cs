using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class VrstaZivotinje : BazniEntitet
    {


        public virtual  string Naziv { get; set; }

        public VrstaZivotinje(int Id) : base(Id)
        {
        }
        public VrstaZivotinje() : base(-1)
        {
        }
    }
}
