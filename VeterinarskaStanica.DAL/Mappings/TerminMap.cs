using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class TerminMap : ClassMap<Termin>
    {
        public TerminMap()
        {
            Id(x => x.Id);
            Map(x => x.Datum);
            Map(x => x.Iskaz);
            Map(x => x.Napomena);
            Map(x => x.Opis);
            Map(x => x.Status);
            References(x => x.VrstaTermina);
            References(x => x.Zivotinja);
            References(x => x.Zaposlenik);
           
            HasMany(x => x.Zahvati).Cascade.All();
            HasMany(x => x.Dokumenti).Cascade.All();

        }
    }
}
