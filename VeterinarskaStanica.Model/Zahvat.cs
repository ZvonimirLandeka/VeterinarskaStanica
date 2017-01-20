using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Zahvat : BazniEntitet
    {
        
        public string Naziv { get; set; }
        public string Napomena { get; set; }
        public List<Lijek> Lijekovi { get; set; }
        public Zahvat(int Id) : base(Id)
        {
        }
        public Zahvat() : base(-1)
        {

        }
    }
}
