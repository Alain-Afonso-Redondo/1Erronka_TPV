using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV_OSIS.Inbentarioa
{
    public class OsagaiakMap : ClassMap<Osagaiak>
    {
        public OsagaiakMap()
        {
            Table("Osagaiak");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Izena);
            Map(x => x.azkenPrezioa);
            Map(x => x.Stock);
            Map(x => x.gutxienekoStock);
            Map(x => x.eskatu);
        }
    }
}
