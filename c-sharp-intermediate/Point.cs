namespace c_sharp_intermediate;

public class Point
{
    public int X;

    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    //move method
    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    //move method overloadding
    public void Move(Point point)
    {
        this.X = point.X;
        this.Y = point.Y;
    }
}
