using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    class Zivotinja : BazniEntitet
    {


        public string Ime { get; set; }
        public int MyProperty { get; set; }
        public virtual VrstaZivotinje VrstaZivotinje { get; set; }
        public virtual PasminaZivotinje PasminaZivotinje { get; set; }
        public DateTime DatumRodenja { get; set; }
        public DateTime DatumSmrti { get; set; }
        public string Boja { get; set; }
        public Spol Spol { get; set; }
        public string BrojCipa { get; set; }
        public string PolozajCipa { get; set; }
        public DateTime DatumCipiranja { get; set; }
        public List<Bolest> Bolesti { get; set; }

        public Zivotinja(int Id) : base(Id)
        {
        }
        public Zivotinja() : base(-1)
        {
        }


    }
}
