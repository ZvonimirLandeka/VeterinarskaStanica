using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class TipZahvata : BazniEntitet
    {
        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public TipZahvata(int Id) : base(Id)
        {
        }
        public TipZahvata() : base(-1)
        {
        }
    }
}
