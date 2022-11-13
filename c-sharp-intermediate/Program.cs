namespace c_sharp_intermediate;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer(1, "John");
        customer.Orders.Add(new Order());
        customer.Orders.Add(new Order());

        // this will reinitialize the Orders field, we will lost the orders that was added above
        // => we don't want the Orders field be assigned multiple time => use readonly for it
        customer.Promote();

        Console.WriteLine(customer.Orders.Count);
    }

    static void UsePoint()
    {
        try
        {
            var myPoint = new Point(1, 2);
            myPoint.Move(null);
            Console.WriteLine("My new point is in ({0}, {1})", myPoint.X, myPoint.Y);

            myPoint.Move(new Point(20, 20));
            Console.WriteLine("My new point is in ({0}, {1})", myPoint.X, myPoint.Y);

        }
        catch (Exception e)
        {
            Console.WriteLine("an unexpected error occured!");
        }
    }

    static void UseParams()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 2, 4));
        Console.WriteLine(calculator.Add(1, 2, 19999));
        Console.WriteLine(calculator.Add(new int[] { 10, 20, 3 }));
    }
}