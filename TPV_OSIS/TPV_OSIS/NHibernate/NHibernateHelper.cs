using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using TPV_OSIS.Eskariak;
using TPV_OSIS.Inbentarioa;

namespace TPV_OSIS
{
    internal class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(
                    MySQLConfiguration.Standard
                        .ConnectionString(cs => cs
                            .Server("192.168.2.101")
                            .Database("erronka1")
                            .Username("2Taldea")
                            .Password("2Taldea2")
                        )
                )
                .Mappings(m =>
                {
                    
                    m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>();
                })
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
