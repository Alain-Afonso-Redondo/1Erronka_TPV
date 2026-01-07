using FluentNHibernate.Mapping;

namespace TPV_OSIS.Eskariak
{
    public class KomandakMap : ClassMap<Komandak>
    {
        public KomandakMap()
        {
            Table("Komandak");
            CompositeId()
                .KeyProperty(x => x.Id, "id")
                .KeyReference(x => x.Platerak, "platerak_id");

            
            Map(x => x.FakturakId)
                .Column("fakturak_id")
                .Not.Nullable();


            Map(x => x.Kopurua)
                .Column("kopurua");

            Map(x => x.Totala)
                .Column("totala");

            Map(x => x.Oharrak)
                .Column("oharrak");



            Map(x => x.Egoera)
                .Column("egoera");
                
        }
    }
}
