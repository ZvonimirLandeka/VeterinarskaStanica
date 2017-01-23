using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class KorisnickiRacun : BazniEntitet
    {
        public virtual string KorisnickoIme { get; set; }
        public virtual string Lozinka { get; set; }


        public KorisnickiRacun(int Id) : base(Id)
        {
        }
        public KorisnickiRacun() : base(-1)
        {
        }
    }
}
