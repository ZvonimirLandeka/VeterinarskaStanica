using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class KorisnickiRacun : BazniEntitet
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }


        public KorisnickiRacun(int Id) : base(Id)
        {
        }
        public KorisnickiRacun() : base(-1)
        {
        }
    }
}
