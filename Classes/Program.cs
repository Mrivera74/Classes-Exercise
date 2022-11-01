namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2016;

            var ford = new Car("Ford", "F150", 2002);

            var acura = new Car("acura", "MDX", 2022);

            var CarList = new List<Car> { myCar, ford, acura };  
            foreach (var vehicle in CarList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

        }

    }


}