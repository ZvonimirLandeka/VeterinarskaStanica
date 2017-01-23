
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    public class PasminaZivotinjeMap : ClassMap<PasminaZivotinje>
    {
        public PasminaZivotinjeMap()
        {
            Id(x => x.Id);
            Map(x => x.Naziv);
            References(x=>x.VrstaZivotinje).Cascade.All();
        }
    }
}
