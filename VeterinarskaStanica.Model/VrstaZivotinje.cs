﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    class VrstaZivotinje : BazniEntitet
    {


        public string Naziv { get; set; }

        public VrstaZivotinje(int Id) : base(Id)
        {
        }
        public VrstaZivotinje() : base(-1)
        {
        }
    }
}
