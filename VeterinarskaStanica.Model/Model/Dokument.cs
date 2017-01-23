using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Dokument : BazniEntitet
    {
        public virtual string Ime { get; set; }
        public virtual byte[] Datoteka { get; set; }
        public Dokument(int Id) : base(Id)
        {
        }
        public Dokument() : base(-1)
        {

        }
    }
}
