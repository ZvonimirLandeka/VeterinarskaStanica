using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Termin : BazniEntitet
    {
        public virtual StatusTermina Status { get; set; }
        public virtual DateTime? Datum { get; set; }
        public virtual VrstaTermina VrstaTermina { get; set; }
        public virtual Zivotinja Zivotinja { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        public virtual string Napomena { get; set; }
        public virtual string Opis { get; set; }
        public virtual string Iskaz { get; set; }
        public virtual IList<Zahvat> Zahvati { get; set; }
        public virtual IList<Dokument> Dokumenti { get; set; }

        public Termin(int Id) : base(Id)
        {
        }
        public Termin() : base(-1)
        {
        }


    }
}
