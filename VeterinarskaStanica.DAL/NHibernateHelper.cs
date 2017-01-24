using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;

namespace VeterinarskaStanica.DAL
{
    public class NHibernateHelper
    {
        private static NHibernate.Cfg.Configuration _config;

        private static ISessionFactory _sessionFactory;

        private static ISession _session;

        private static DatabaseType DatabaseDataLocation = DatabaseType.File;

        public static void SetDatabaseType(DatabaseType type)
        {
            DatabaseDataLocation = type;
        }

        public static ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = OpenSessionFactory();
                }
                ISession session = _sessionFactory.OpenSession();

                if(DatabaseDataLocation == DatabaseType.InMemory)
                {
                    BuildSchema(session);
                }

                return session;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        public static ISession CurrentSession
        {
            get
            {
                if(_session == null)
                {
                    _session = OpenSession();
                }

                return _session;
            }
        }

        public static ISessionFactory OpenSessionFactory()
        {
            try
            {
                if (DatabaseDataLocation == DatabaseType.InMemory)
                {
                    _sessionFactory = Fluently.Configure()
                    .Database(SQLiteConfiguration.Standard.InMemory().ShowSql().FormatSql())
                    .Mappings(mapper => { mapper.FluentMappings.AddFromAssemblyOf<PasminaZivotinjeMap>(); })
                    .ExposeConfiguration(c => { _config = c; })
                    .BuildSessionFactory();

                }

                if(DatabaseDataLocation == DatabaseType.File)
                {
                    var fluentConfig = Fluently.Configure()
                                   .Database(SQLiteConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey("VeterinarskaStanicaDatabase")).AdoNetBatchSize(100))
                                   .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<PasminaZivotinjeMap>());

                    var nhConfig = fluentConfig.BuildConfiguration();

                    _sessionFactory = nhConfig.BuildSessionFactory();
                }

                // this is for rebuilding the database
                //ISession Session = _sessionFactory.OpenSession();

                //using (var tx = Session.BeginTransaction())
                //{
                //    new SchemaExport(nhConfig).Execute(useStdOut: true,
                //                                                execute: true,
                //                                                justDrop: false,
                //                                                connection: Session.Connection,
                //                                                exportOutput: Console.Out);
                //    tx.Commit();
                //}


            }
            catch (Exception)
            {

                throw;
            }

            return _sessionFactory;
        }

        private static void BuildSchema(ISession session)
        {
            var export = new SchemaExport(_config);
            export.Execute(true, true, false, session.Connection, null);
        }

        public static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var vz = new VrstaZivotinje()
                    {
                        Naziv = "Pas"

                    };
                    var pz = new PasminaZivotinje()
                    {

                        Naziv = "Ovcar",
                        VrstaZivotinje = vz
                    };
                    session.Save(pz);

                    var pero = new Zivotinja()
                    {
                        Boja = "Crna",
                        BrojCipa = "123",
                        Ime = "Pero",
                        PasminaZivotinje = pz,
                        VrstaZivotinje = vz,
                        Spol=Spol.Muško
                    };

                    ////transaction.Commit();

                    var lijek1 = new Lijek()
                    {
                        Naziv = "test1"
                    };
                    var lijek2 = new Lijek()
                    {
                        Naziv = "lijek2"
                    };
                    var lijek3 = new Lijek()
                    {
                        Naziv = "lijek3"
                    };
                    var lijek4 = new Lijek()
                    {
                        Naziv = "lijek4"
                    };
                    IList<Lijek> lijekovi = new List<Lijek>();
                    lijekovi.Add(lijek1);
                    lijekovi.Add(lijek2);
                    lijekovi.Add(lijek3);
                    lijekovi.Add(lijek4);
                    session.Save(lijek1);
                    session.Save(lijek2);
                    session.Save(lijek3);
                    session.Save(lijek4);


                    var Zahvat = new Zahvat()
                    {
                        Lijekovi = lijekovi,
                        Napomena = "nista",
                        Naziv = "Testni zahvat"
                    };
                    session.Save(Zahvat);
                    transaction.Commit();
                }
            }

        }
    }

    public enum DatabaseType
    {
        File,
        InMemory,        
    }

}
