using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV_OSIS.Eskariak
{
    public class MahaiakMap: ClassMap<Mahaiak>
    {
        public MahaiakMap()
        {
            Table("Mahaiak");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.mahaiZenbakia);
            Map(x => x.pertsonaKopurua);
        }
    }
}
