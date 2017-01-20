using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    class Bolest : BazniEntitet
    {
 
        public string Naziv { get; set; }
        public Bolest(int Id) : base(Id)
        {
        }
        public Bolest():base(-1)
        {

        }
    }
}
