using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class KorisnickiRacunMap : ClassMap<KorisnickiRacun>
    {
        public KorisnickiRacunMap()
        {
            Id(x => x.Id);
            Map(x => x.Lozinka);
            Map(x => x.KorisnickoIme);
            



        }
    }
}
