using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public abstract class Osoba : BazniEntitet
    {

        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string OIB { get; set; }
        public virtual string Adresa { get; set; }
        public virtual Spol Spol { get; set; }

        public Osoba(int Id) : base(Id)
        {
        }
        public Osoba() : base(-1)
        {
        }

    }
}
