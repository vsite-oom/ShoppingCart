namespace ShoppingCart
{
    public class Program
    {
        static void Main(string[] args)
        {
            //initialize shop
            var stock = new Stock();
            var cashRegister = new CashRegister();

            //define products
            var cola = new Product("Coca-Cola 0.5L", 1.05);
            var colaZero = new Product("Coca-Cola Zero 0.5L", 1.45);
            var fanta = new Product("Fanta 0.5L", 1.05);
            var sprite = new Product("Sprite 0.5L", 1.05);
            var cocta = new Product("Cocta 0.5L", 1.19);
            var hidra = new Product("Hidra Iso", 1.19);
            var pipi = new Product("Pipi", 1.19);
            var cedevita = new Product("Cedevita", 1.09);
            var voda = new Product("Voda", 0.79);

            //add products to stock
            stock.AddStock(cola, 1000);
            stock.AddStock(fanta, 20);
            stock.AddStock(sprite, 10);
            stock.AddStock(cocta, 100);
            stock.AddStock(hidra, 1000);
            stock.AddStock(pipi, 100);
            stock.AddStock(cedevita, 3);
            stock.AddStock(voda, 20);

            //user enters store and picks items
            var shoppingCart = new Cart();
            shoppingCart.AddProduct(stock, cola, 10);
            shoppingCart.AddProduct(stock, cocta, 2);
            shoppingCart.AddProduct(stock, hidra, 24);
            shoppingCart.RemoveProduct(stock, cocta, 2);
            shoppingCart.AddProduct(stock, pipi, 12);
            var price = cashRegister.CalculateAmount(shoppingCart);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Suma računa: {price}");

        }
    }
}
