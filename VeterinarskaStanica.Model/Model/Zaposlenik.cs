﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
    public class Zaposlenik : Osoba
    {
        public virtual VrstaZaposlenika VrstaZaposlenika { get; set; }

        public Zaposlenik(int Id) : base(Id)
        {
        }
        public Zaposlenik() : base(-1)
        {

        }
    }
}
