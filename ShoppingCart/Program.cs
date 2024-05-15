namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shopper kupac1 = new Shopper("Ivo", "Ivic");

            Shop msan = new Shop("Msan");

            while (true)
            {
                Console.WriteLine("Select item: ");

                Console.WriteLine("Are you done?");

                Console.WriteLine("Checkout?");
            }

            Console.WriteLine("Total to pay: ");

            Console.WriteLine("Thank you and come back!");


        }
    }
}
