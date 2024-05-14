namespace VSITE.OOM.ShoppingCart

{
    public class Skladiste
    {
        public List<Artikl> Artikli { get; private set; }

        public Skladiste()
        {
            Artikli = new List<Artikl>();
        }
    }
}
