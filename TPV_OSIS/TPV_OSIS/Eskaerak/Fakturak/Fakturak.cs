namespace TPV_OSIS.Eskaerak {
    public class Fakturak
    {
        public virtual int Id { get; set; }
        public virtual double Totala { get; set; }
        public virtual bool Egoera { get; set; }
        public virtual byte[] FakturaPdf { get; set; }

        public virtual Erreserbak Erreserbak { get; set; }
    }
}
