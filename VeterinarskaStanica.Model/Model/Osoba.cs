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
        public virtual string KorisnickoIme { get; set; }
        public virtual string Lozinka { get; set; }
        public virtual IList<Dokument> Dokumenti { get; set; }

        public virtual string ImePrezimeOib { get { return $"{Ime} {Prezime} ({OIB})"; } }

        public Osoba(int Id) : base(Id)
        {
        }
        public Osoba() : base(-1)
        {
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime} ({OIB})";
        }
    }
}
