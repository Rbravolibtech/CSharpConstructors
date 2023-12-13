namespace CSharpConstructors
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jon");

            //The code bellow is another way of coding
            //like the code above this comment just longer

            //customer.Id = 1;
            //customer.Name = "Jon";
            

            var order = new Order();
            customer.orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
