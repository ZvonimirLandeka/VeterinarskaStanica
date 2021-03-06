﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class VrstaTermina : BazniEntitet
    {
        public virtual string Naziv { get; set; }

        public VrstaTermina(int Id) : base(Id)
        {
        }
        public VrstaTermina() : base(-1)
        {
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
