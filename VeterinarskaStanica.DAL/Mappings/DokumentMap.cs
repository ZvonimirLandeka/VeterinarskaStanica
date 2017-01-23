using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class DokumentMap : ClassMap<Dokument>
    {
        public DokumentMap()
        {
            Id(x => x.Id);
            Map(x => x.Ime);
            Map(x => x.Datoteka);


        }
    }
}
