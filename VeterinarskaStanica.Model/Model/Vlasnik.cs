using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Vlasnik : Osoba
    {
        public Vlasnik(int Id) : base(Id)
        {
        }
        public Vlasnik() : base(-1)
        {
        }

    }
}
