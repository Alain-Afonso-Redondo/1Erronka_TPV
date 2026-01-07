using FluentNHibernate.Mapping;

namespace TPV_OSIS.Eskariak
{
    public class PlaterakMap : ClassMap<Platerak>
    {
        public PlaterakMap()
        {
            Table("Platerak");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Izena);
            Map(x => x.Prezioa);
            Map(x => x.Stock);
            References(x => x.Kategoriak).Column("Kategoriak_id");
        }
    }
}
