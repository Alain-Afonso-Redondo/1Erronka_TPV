using FluentNHibernate.Mapping;

namespace TPV_OSIS.Eskariak
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
