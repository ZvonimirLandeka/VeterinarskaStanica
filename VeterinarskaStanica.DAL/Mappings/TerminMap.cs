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
            References(x => x.VrstaTermina);
            References(x => x.Zivotinja);
            References(x => x.Zaposlenik);
            References(x => x.Status);
            HasMany(x => x.Zahvati);
            HasMany(x => x.Dokumenti);

        }
    }
}
