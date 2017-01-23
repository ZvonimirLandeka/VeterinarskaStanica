using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    class ZaposlenikMap : SubclassMap<Zaposlenik>
    {
        public ZaposlenikMap()
        {
            References(x => x.VrstaZaposlenika);
        }
    }
}
