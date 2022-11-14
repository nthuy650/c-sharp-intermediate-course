namespace c_sharp_intermediate;

public class Person
{
    // this will create Birthdate property
    // Birthdate property == create private _birthdate field with getter and setter
    public DateTime Birthdate { get; private set; }

    public Person(DateTime birthdate)
    {
        this.Birthdate = birthdate;
    }

    // create Age property based on Birthdate property
    // Age is a calculated property
    public int Age {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }
}
