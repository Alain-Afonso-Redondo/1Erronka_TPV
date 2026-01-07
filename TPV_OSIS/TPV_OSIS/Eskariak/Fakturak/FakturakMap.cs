using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV_OSIS.Eskariak
{
    public class FakturakMap : ClassMap <Fakturak>
    {
        public FakturakMap()
        {
            Table("Fakturak");

            Id(x => x.Id).GeneratedBy.Assigned();
            

            Map(x => x.Totala)
                .Column("totala")
                .Not.Nullable();

            Map(x => x.Egoera)
              .Column("egoera")
              .Not.Nullable();

            Map(x => x.FakturaPdf)
                .Column("faktura_pdf")
                .Nullable();

            References(x => x.Erreserbak)
                .Column("erreserbak_id")
                .Not.Nullable();
        }
    }
}
