using System;

namespace TPV_OSIS.Eskariak
{
    public class Erreserbak
    {
        public virtual int Id { get; set; }
        public virtual string Izena { get; set; }
        public virtual string Telefonoa { get; set; }
        public virtual string Txanda { get; set; }
        public virtual int PertsonaKopurua { get; set; }
        public virtual DateTime Data { get; set; }
    }
}
