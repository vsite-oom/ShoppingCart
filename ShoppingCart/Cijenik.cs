namespace VSITE.OOM.ShoppingCart

{
    public class Cijenik
    {
        public Dictionary<string, double> Cijene { get; private set; }

        public Cijenik()
        {
            Cijene = new Dictionary<string, double>();
        }
    }
}
