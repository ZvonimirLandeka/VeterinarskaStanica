using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    public class VrstaZivotinjeMap : ClassMap<VrstaZivotinje>
    {
        public VrstaZivotinjeMap()
        {
            Id(x => x.Id);
            Map(x => x.Naziv);
        }
    }
}
