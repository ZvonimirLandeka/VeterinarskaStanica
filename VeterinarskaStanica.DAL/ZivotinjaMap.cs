using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class ZivotinjaMap : ClassMap<Zivotinja>
    {
        public ZivotinjaMap()
        {
            Id(x => x.Id);
            Map(x => x.Boja);
            Map(x => x.BrojCipa);
            Map(x => x.DatumCipiranja);
            Map(x => x.DatumRodenja);
            Map(x => x.DatumSmrti);
            Map(x => x.Ime);
            Map(x => x.PolozajCipa);
            Map(x => x.Spol);

            References(x => x.PasminaZivotinje);
            References(x => x.VrstaZivotinje);
            References(x => x.Vlasnik);

            HasMany(x => x.Dokumenti);
            HasMany(x => x.Bolesti);



        }
    }
}
