using OrderGenerator.Entities;
using OrderGenerator.Entities.Enums;

namespace OrderGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create object order 

                Console.WriteLine("Enter client data: ");

                Console.Write("Name: ");
                string userName = Console.ReadLine();

                Console.Write("Email: ");
                string userEmail = Console.ReadLine();

                Console.Write("Birth date (MM/DD/YYYY): ");
                DateTime userBirthdate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter order data: ");
                Console.Write("Status: ");
                OrderStatus userStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

                Client client = new Client(userName, userEmail, userBirthdate);
                Order order = new Order(DateTime.Now, userStatus, client);

                // Loop through the items of the order
                Console.WriteLine();
                Console.Write("How many items to this order? ");
                int amountOfOrders = int.Parse(Console.ReadLine());

                for(int i = 1; i <= amountOfOrders; i++)
                {
                    Console.WriteLine($"Enter #{i} item data: ");
                    Console.Write("Product name: ");
                    string productName = Console.ReadLine();

                    Console.Write("Product price: ");
                    double productPrice = double.Parse(Console.ReadLine());

                    Product product = new Product(productName, productPrice);

                    Console.Write("Quantity: ");
                    int productQuantity = int.Parse(Console.ReadLine());

                    OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
                    order.AddItem(orderItem);
                }

                Console.WriteLine();
                Console.WriteLine("Order Summary: ");
                Console.WriteLine(order);
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(e.Message);
            }
        }
    }
}