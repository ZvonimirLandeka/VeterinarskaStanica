using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Lijek : BazniEntitet
    {

        public int Id { get; set; }
        public string Naziv { get; set; }
        public Lijek(int Id) : base(Id)
        {
        }
        public Lijek() : base(-1)
        {
        }
    }
}
