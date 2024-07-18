namespace Classes;

public class Car
{       //Constructor

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    //Default Constructor
    public Car()
    {
        
    }
    //Fields
    //Properties
    //Methods
    //Creat a Make property of type string that is public
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}
