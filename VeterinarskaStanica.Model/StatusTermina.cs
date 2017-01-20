using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class StatusTermina : BazniEntitet
    {
        public StatusTermina(int Id) : base(Id)
        {
        }
        public StatusTermina() : base(-1)
        {
        }

        public string Naziv { get; set; }

    }
}
