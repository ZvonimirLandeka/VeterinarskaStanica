using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.DAL;

namespace VeterinarskaStanica.BLL
{
    public static class DbHelper
    {
        public static void UseFileDatabase()
        {
            NHibernateHelper.SetDatabaseType(DatabaseType.File);
        }

        public static void UseInMemoryDatabase()
        {
            NHibernateHelper.SetDatabaseType(DatabaseType.InMemory);
        }
    }
}
