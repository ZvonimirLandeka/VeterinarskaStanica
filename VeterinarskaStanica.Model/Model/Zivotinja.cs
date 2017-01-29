using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Zivotinja : BazniEntitet
    {
        public virtual string Ime { get; set; }
        public virtual VrstaZivotinje VrstaZivotinje { get; set; }
        public virtual PasminaZivotinje PasminaZivotinje { get; set; }
        public virtual DateTime? DatumRodenja { get; set; }
        
        public virtual DateTime? DatumSmrti { get; set; }
        public virtual string Boja { get; set; }
        public virtual Spol Spol { get; set; }
        public virtual string BrojCipa { get; set; }
        public virtual string PolozajCipa { get; set; }
        public virtual DateTime? DatumCipiranja { get; set; }
        public virtual IList<Bolest> Bolesti { get; set; }
        public virtual Vlasnik Vlasnik { get; set; }
        public virtual IList<Dokument> Dokumenti { get; set; }

        public Zivotinja(int Id) : base(Id)
        {
        }
        public Zivotinja() : base(-1)
        {
        }


    }
}
