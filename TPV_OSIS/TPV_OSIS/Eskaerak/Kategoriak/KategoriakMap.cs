using FluentNHibernate.Mapping;

namespace TPV_OSIS.Eskaerak
{
    public class KategoriakMap : ClassMap<Kategoriak>
    {
        public KategoriakMap()
        {
            Table("Kategoriak");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Izena);
        }
    }
}
