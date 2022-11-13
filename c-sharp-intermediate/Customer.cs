namespace c_sharp_intermediate;

public class Customer
{
    public int Id;
    public string Name;

    // initialize
    public List<Order> Orders = new List<Order>();

    //first constructor
    public Customer(int id)
    {
        this.Id = id;
    }

    //second constructor
    public Customer(int id, string name)
        : this(id)
        // go to abou
    {
        this.Id = id;
        this.Name = name;
    }

    public void Promote()
    {
        this.Orders = new List<Order>();
        //...
    }
}
