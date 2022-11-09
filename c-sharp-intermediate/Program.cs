namespace c_sharp_intermediate;

class Program
{
    static void Main(string[] args)
    {
        //create a Customer instance
        var customer1 = new Customer();
        // default constructor will assign 0 to Id and null to Name
        Console.Write(customer1.Id); //0
        Console.WriteLine(customer1.Name); //null

        // using the first constructor
        var customer2 = new Customer(1);
        Console.Write(customer2.Id); //1
        Console.WriteLine(customer2.Name); //null

        // using the second constructor
        var customer3 = new Customer(2, "John");
        Console.Write(customer3.Id); //2
        Console.WriteLine(customer3.Name); //John

        var order = new Order();
        // this will throw error: Object reference is not set to an instance of an object
        // if customer1 didn't initialize Order in its constructor
        // if we comment the line 14 in the Customer.cs
        customer1.Orders.Add(order);
    }
}