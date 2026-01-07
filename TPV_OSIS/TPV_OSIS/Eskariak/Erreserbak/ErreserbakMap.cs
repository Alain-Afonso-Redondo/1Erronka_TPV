using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV_OSIS.Eskariak
{
    public class ErreserbakMap : ClassMap<Erreserbak>
    {
        internal ErreserbakMap()
        {
            Table("Erreserbak");

            Id(x => x.Id).GeneratedBy.Assigned(); 

            Map(x => x.Izena)
                .Column("izena")
                .Not.Nullable();

            Map(x => x.Telefonoa)
                .Column("telefonoa")
                .Not.Nullable();

            Map(x => x.Txanda)
                .Column("txanda")
                .Not.Nullable();

            Map(x => x.PertsonaKopurua)
                .Column("pertsona_kopurua")
                .Not.Nullable();

            Map(x => x.Data)
                .Column("data")
                .Not.Nullable();
        }
    }
}
