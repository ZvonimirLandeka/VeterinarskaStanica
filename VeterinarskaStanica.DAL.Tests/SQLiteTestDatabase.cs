using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace VeterinarskaStanica.DAL.Tests
{
    class SQLiteTestDatabase : IDisposable
    {
        protected Configuration config;
        protected ISessionFactory sessionFactory;
        public SQLiteTestDatabase()
        {
            /* Programmatic configuration
            config = new Configuration()
                .SetProperty(Environment.ReleaseConnections, "on_close")
                .SetProperty(Environment.Dialect, typeof(SQLiteDialect).AssemblyQualifiedName)
                .SetProperty(Environment.ConnectionDriver, typeof(SQLite20Driver).AssemblyQualifiedName)
                .SetProperty(Environment.ConnectionString, "data source =:memory: ")
                .AddAssembly("FinAssist.DAL");

            _sessionFactory = config.BuildSessionFactory();

            Session = _sessionFactory.OpenSession();

            new SchemaExport(config).Execute(true, true, false, Session.Connection , Console.Out);

            */

            // Fluent configuration
            var fluentConfig = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.UsingFile("TestDB.db")
                    .ShowSql().FormatSql())
                    .Mappings(mapper =>
                    {
                        // možemo dodati automatski sva mapiranja iz određenog asemblija
                        mapper.FluentMappings.AddFromAssemblyOf<PasminaZivotinjeMap>();

                        // a možemo ih dodavati i pojedinačno
                        //mapper.FluentMappings.Add<ExpenditureCategoryMap>();
                        //mapper.FluentMappings.Add<AccountMap>();
                        //mapper.FluentMappings.Add<AccountWithBalanceMap>();
                        //mapper.FluentMappings.Add<CashAccountMap>();
                        //mapper.FluentMappings.Add<CreditCardAccountMap>();
                        //mapper.FluentMappings.Add<DebitCardAccountMap>();
                    });

            var nhConfiguration = fluentConfig.BuildConfiguration();
            sessionFactory = nhConfiguration.BuildSessionFactory();

            Session = sessionFactory.OpenSession();

            using (var tx = Session.BeginTransaction())
            {
                new SchemaExport(nhConfiguration).Execute(useStdOut: true,
                                                            execute: true,
                                                            justDrop: false,
                                                            connection: Session.Connection,
                                                            exportOutput: Console.Out);
                tx.Commit();
            }

        }

        public ISession Session { get; set; }
        public void Dispose()
        {
            Session.Dispose();
            sessionFactory.Dispose();
        }
    }
}
