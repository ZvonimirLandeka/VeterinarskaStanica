using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public abstract class BazniEntitet
    {
        public virtual int Id { get; set; }

        public BazniEntitet(int Id)
        {
            this.Id = Id;
        }

    }
}
