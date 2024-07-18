namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;
            
            // Car mazda = new Car()
            // {
            //     Make = "Mazda",
            //     Model = "CXX-5",
            //     Year = 2020
            // }


            Car mySecondCar = new Car("Chevy", "Silverado", 2011);
            
            Console.WriteLine(mySecondCar.Make);
            Console.WriteLine(mySecondCar.Model);
            Console.WriteLine(mySecondCar.Year);





        }
    }
}
