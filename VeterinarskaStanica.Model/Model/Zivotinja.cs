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
        [Required]
        public virtual string Ime { get; set; }
        [Display(Name = "Vrsta životinje")]
        public virtual VrstaZivotinje VrstaZivotinje { get; set; }
        [Display(Name = "Pasmina životinje")]
        public virtual PasminaZivotinje PasminaZivotinje { get; set; }
        [Display(Name = "Datum rođenja")]
        public virtual DateTime? DatumRodenja { get; set; }
        [Display(Name = "Datum smrti")]
        public virtual DateTime? DatumSmrti { get; set; }
        public virtual string Boja { get; set; }
        public virtual Spol Spol { get; set; }
        [Display(Name = "Broj čipa")]
        public virtual string BrojCipa { get; set; }
        [Display(Name = "Položaj čipa")]
        public virtual string PolozajCipa { get; set; }
        [Display(Name = "Datum čipiranja")]
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

        public override string ToString()
        {
            return $"{Ime} - {VrstaZivotinje} - ({BrojCipa})";
        }
    }
}
