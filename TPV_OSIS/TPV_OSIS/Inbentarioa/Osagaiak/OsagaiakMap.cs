using FluentNHibernate.Mapping;

namespace TPV_OSIS.Inbentarioa
{
    public class OsagaiakMap : ClassMap<Osagaiak>
    {
        public OsagaiakMap()
        {
            Table("Osagaiak");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity();

            Map(x => x.Izena)
                .Column("izena");

            Map(x => x.azkenPrezioa)
                .Column("azken_prezioa");

            Map(x => x.Stock)
                .Column("stock");

            Map(x => x.gutxienekoStock)
                .Column("gutxieneko_stock");

            Map(x => x.eskatu)
                .Column("eskatu");
        }
    }
}
