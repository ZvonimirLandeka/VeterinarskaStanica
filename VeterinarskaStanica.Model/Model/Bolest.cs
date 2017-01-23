using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Bolest : BazniEntitet
    {

        public virtual string Naziv { get; set; }
        public Bolest(int Id) : base(Id)
        {
        }
        public Bolest():base(-1)
        {

        }
    }
}
