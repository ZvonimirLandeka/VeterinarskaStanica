using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class VrstaZahvata : BazniEntitet
    {
        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public VrstaZahvata(int Id) : base(Id)
        {
        }
        public VrstaZahvata() : base(-1)
        {
        }
    }
}
