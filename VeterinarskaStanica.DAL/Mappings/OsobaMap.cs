using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class OsobaMap : ClassMap<Osoba>
    {
        public OsobaMap()
        {
            Id(x => x.Id);
            Map(x => x.Ime);
            Map(x => x.Adresa);
            Map(x => x.OIB);
            Map(x => x.Prezime);
            Map(x => x.Spol);
            Map(x => x.KorisnickoIme);
            Map(x => x.Lozinka);
            HasMany(x => x.Dokumenti);

        }
    }
}
