using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Termin : BazniEntitet
    {
        public Termin(int Id) : base(Id)
        {
        }
        public Termin() : base(-1)
        {
        }

        public StatusTermina Status { get; set; }
        public DateTime Datum { get; set; }
        public VrstaTermina VrstaTermina { get; set; }
        public Zivotinja Zivotinja { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        public string Napomena { get; set; }
        public string Opis { get; set; }
        public string Iskaz { get; set; }
        public List<Zahvat> Zahvati { get; set; }

    }
}
