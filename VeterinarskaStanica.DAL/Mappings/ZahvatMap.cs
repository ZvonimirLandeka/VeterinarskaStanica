using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class ZahvatMap : ClassMap<Zahvat>
    {
        public ZahvatMap()
        {
            Id(x => x.Id);
            Map(x => x.Naziv);

            Map(x => x.Napomena);
            HasMany(x => x.Lijekovi);


        }
    }
}
