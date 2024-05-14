namespace VSITE.OOM.ShoppingCart

{
    public class Artikl
    {
        public string Naziv { get; private set; }                          
        public double Cijena { get; private set; }
        public int Kolicina { get; private set; }

        public Artikl(string naziv, double cijena, int kolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            Kolicina = kolicina;
        }
    }
}
