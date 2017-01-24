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
        private static ISessionFactory _sessionFactory;


        public static ISession OpenSession()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = OpenSessionFactory();
                }
                ISession session = _sessionFactory.OpenSession();
                return session;
            }
            catch (Exception e)
            {
                throw e.InnerException ?? e;
            }
        }

        public static ISessionFactory OpenSessionFactory()
        {
            try
            {
                var fluentConfig = Fluently.Configure()
                                    .Database(SQLiteConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey("VeterinarskaStanicaDatabase")).AdoNetBatchSize(100))
                                    .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<PasminaZivotinjeMap>());

                var nhConfig = fluentConfig.BuildConfiguration();

                _sessionFactory = nhConfig.BuildSessionFactory();

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
        /*
         *    //public IDatabase Database { private get; set; }
                //public NHibernateService(IDatabase database)
                //{
                //    Database = database;
                //}

                public void CreateDatabaseAndSchema()
                {
                    _sessionFactory = null; //obriše se eventualni prošli session
                    if (Database == null)
                    {
                        return;
                    }
                    Database.CreateDatabase(Database.DBInfo);
                    CreateSchema();
                }

                private void CreateSchema()
                {
                    var configuration = Database.GetFluentConfiguration();
                    configuration.Mappings(m => m.FluentMappings.AddFromAssemblyOf<InspectionMapping>()).
                                  ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true)).
                                  BuildSessionFactory();
                }

                public ISession CreateSchemaOpenSession(IDatabaseInfo inDB)
                {
                    _sessionFactory = null; //obriše se eventualni prošli session
                    if (Database == null)
                    {
                        return null;
                    }
                    CreateSchema();
                    return OpenSession();
                }
                */
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
                    ////transaction.Commit();

                    var lijek1 = new Lijek()
                    {
                        Naziv="test1"
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
                    IList<Lijek> lijekovi= new List<Lijek>();
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

}
