using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class VrstaZaposlenika : BazniEntitet
    {

        public string Naziv { get; set; }


        public VrstaZaposlenika(int Id) : base(Id)
        {
        }
        public VrstaZaposlenika() : base(-1)
        {
        }
    }
}
