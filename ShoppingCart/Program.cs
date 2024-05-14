using VSITE.OOM.ShoppingCart;

namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kreiramo testong kupca
            Kupac kupac = new Kupac("Tester");

            // kreiramo testnu trgovinu
            Trgovina trgovina = new Trgovina("Testna trgovina");
        }
    }
}
