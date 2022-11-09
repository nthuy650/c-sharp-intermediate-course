namespace c_sharp_intermediate;

public class Customer
{
    public int Id;
    public string Name;

    // this will need to be initialized in the constructor as an empty list
    public List<Order> Orders;

    // default constructor will like this
    public Customer()
    {
        Orders = new List<Order>();
    }

    //first constructor
    public Customer(int id)
        // go to above constructor before running this constructor
        : this()
    {
        this.Id = id;
    }

    //second constructor
    public Customer(int id, string name)
        // go to abou
    {
        this.Id = id;
        this.Name = name;
    }
}
