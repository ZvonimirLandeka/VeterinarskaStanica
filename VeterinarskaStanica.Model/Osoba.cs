using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public abstract class Osoba : BazniEntitet
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }
        public Spol Spol { get; set; }

        public Osoba(int Id) : base(Id)
        {
        }
        public Osoba() : base(-1)
        {
        }

    }
}
