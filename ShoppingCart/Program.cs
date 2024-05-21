namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pricelist = GeneratePricelist();
            var warehouse = GenerateWarehouse();
            var store = new Store(pricelist, warehouse);
            var user = new User { Id = 1, Name = "Antonio" };

            DisplayProducts(store.GetProducts());

            while (true)
            {
                Console.Write("Enter command: ");
                var input = Console.ReadLine();
                var inputParts = input!.Split(' ');
                var command = inputParts[0];

                if (inputParts.Length == 1)
                {
                    switch (command)
                    {
                        case "p":
                        {
                            Console.WriteLine($"Total price: {user.GetCartValue()}");
                            break;
                        }
                        case "c":
                        {
                            foreach (var item in user.GetCart())
                            {
                                store.AddStock(item.Key, item.Value);
                            }
                            user.ClearCart();

                            Console.WriteLine("Removed all items from cart!");
                            break;
                        }
                    }
                }
                else if (inputParts.Length == 3)
                {
                    var productId = int.Parse(inputParts[1]);
                    var quantity = int.Parse(inputParts[2]);
                    var product = store.GetProductById(productId);

                    if (quantity <= 0)
                    {
                        Console.WriteLine("Quantity must be bigger than zero");
                        return;
                    }

                    switch (command)
                    {
                        case "a":
                        {
                            product.Price = pricelist.GetPrice(product);

                            AddProductToCart(user, store, quantity, product);
                            break;
                        }
                        case "r":
                        {
                            RemoveProductFromCart(store, user, quantity, product);
                            break;
                        }

                    }
                }
            }
        }

        private static void RemoveProductFromCart(Store store, User user, int quantity, Product product)
        {
            user.RemoveFromCart(product, quantity);
            store.AddStock(product, quantity);

            DisplayCart(user);
        }
        private static void AddProductToCart(User user, Store store, int quantity, Product product)
        {
            if (store.IsProductAvailable(product, quantity))
            {
                user.AddToCart(product, quantity);
                store.RemoveStock(product, quantity);

                DisplayCart(user);
            }
            else
            {
                Console.WriteLine("Product is not available.");
            }
        }


        private static void DisplayCart(User user)
        {
            Console.WriteLine("Cart:");
            foreach (var item in user.GetCart())
            {
                Console.WriteLine($"{item.Key.Name}: {item.Value}");
            }
            Console.WriteLine();
        }
        private static void DisplayProducts(Dictionary<Product, decimal> products)
        {
            Console.WriteLine("Welcome to Shop!");
            Console.WriteLine("Commands");
            Console.WriteLine("a - add product (a id quantity)");
            Console.WriteLine("r - remove product (r id quantity)");
            Console.WriteLine("p - go to payment");
            Console.WriteLine("c - clear cart");
            Console.WriteLine();

            Console.WriteLine("Choose product(s):");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key.Id}. {product.Key.Name} - {product.Value}");
            }
        }

        private static Pricelist GeneratePricelist()
        {
            Pricelist pricelist = new();
            pricelist.AddProduct(new Product { Id = 1, Name = "Apple" }, 0.5m);
            pricelist.AddProduct(new Product { Id = 2, Name = "Banana" }, 0.7m);
            pricelist.AddProduct(new Product { Id = 3, Name = "Orange" }, 0.6m);
            pricelist.AddProduct(new Product { Id = 4, Name = "Pineapple" }, 1.0m);

            return pricelist;
        }
        private static Warehouse GenerateWarehouse()
        {
            Warehouse warehouse = new();
            warehouse.AddProduct(new Product { Id = 1, Name = "Apple" }, 10);
            warehouse.AddProduct(new Product { Id = 2, Name = "Banana" }, 20);
            warehouse.AddProduct(new Product { Id = 3, Name = "Orange" }, 15);
            warehouse.AddProduct(new Product { Id = 4, Name = "Pineapple" }, 5);

            return warehouse;
        }
    }
}
