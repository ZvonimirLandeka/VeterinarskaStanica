﻿using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class VrstaZahvataMap : ClassMap<VrstaZahvata>
    {
        public VrstaZahvataMap()
        {
            Id(x => x.Id);
            Map(x => x.Naziv);
            Map(x => x.Opis);


        }
    }
}
