namespace c_sharp_intermediate;

class Program
{
    static void Main(string[] args)
    {
        var myPoint = new Point(1, 2);
        myPoint.Move(null);
        Console.WriteLine("My new point is in ({0}, {1})", myPoint.X, myPoint.Y);

        myPoint.Move(new Point(20, 20));
        Console.WriteLine("My new point is in ({0}, {1})", myPoint.X, myPoint.Y);
    }
}