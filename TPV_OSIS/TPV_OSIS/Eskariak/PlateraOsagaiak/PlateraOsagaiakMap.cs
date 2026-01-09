using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV_OSIS.Inbentarioa;

namespace TPV_OSIS.Eskariak
{
    internal class PlateraOsagaiakMap: ClassMap<PlateraOsagaiak>
    {
        public PlateraOsagaiakMap()
        {
            Table("Platerak_Osagaiak");

            Id(x => x.Id)
                .Column("id")
                .GeneratedBy.Identity();

            References(x => x.Platera)
                .Column("platerak_id")
                .Not.Nullable();

            References(x => x.Osagaia)
                .Column("osagaiak_id")
                .Not.Nullable();

            Map(x => x.Kopurua)
                .Column("kopurua")
                .Not.Nullable();
        }
    }
}
