using TPV_OSIS.Eskariak.Erreserbak;

namespace TPV_OSIS.Eskariak {
    public class Fakturak
    {
        public virtual int Id { get; set; }
        public virtual double Totala { get; set; }
        public virtual bool Egoera { get; set; }
        public virtual byte[] FakturaPdf { get; set; }

        public virtual Erreserba Erreserbak { get; set; }
    }
}
