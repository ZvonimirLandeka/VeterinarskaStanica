using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Zahvat : BazniEntitet
    {

        public virtual string Naziv { get; set; }
        public virtual string Napomena { get; set; }
        public virtual IList<Lijek> Lijekovi { get; set; }
        public Zahvat(int Id) : base(Id)
        {
        }
        public Zahvat() : base(-1)
        {

        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
