namespace c_sharp_intermediate;

public class Person
{
    // this will create Birthdate property
    // Birthdate property == create private _birthdate field with getter and setter
    public DateTime Birthdate { get; set; }

    // create Age property based on Birthdate property
    public int Age {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }
}
