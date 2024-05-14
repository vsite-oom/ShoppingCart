namespace VSITE.OOM.ShoppingCart

{
    public class Trgovina
    {
        public Skladiste Skladiste { get; private set; }
        public Cijenik Cijenik { get; private set; }
        public string Ime { get; private set; }


        public Trgovina(string ime)
        {
            Skladiste = new Skladiste();
            Cijenik = new Cijenik();
            Ime = ime;
        }
    }
}
