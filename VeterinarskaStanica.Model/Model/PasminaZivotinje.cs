using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class PasminaZivotinje : BazniEntitet
    {

        public virtual string Naziv { get; set; }
        public virtual VrstaZivotinje VrstaZivotinje { get; set; }

        public PasminaZivotinje(int Id) : base(Id)
        {
        }
        public PasminaZivotinje() : base(-1)
        {
        }

    }
}
