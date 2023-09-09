namespace CarApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the CarApp\n");

            var audi = new Car("Audi", "A6", 90, 200,
                new Transmission("Automatic", 7));
            var bmw = new Car("BMW", "X5", 100, 190,
                new Transmission("Manual", 6));
            ;

            audi.DisplayInfo();
            bmw.DisplayInfo();

            Console.WriteLine("\n----------------------------------------------\n");

            audi.Accelerate(200);
            bmw.Brake(1000);

            Console.WriteLine("\n----------------------------------------------\n");

            audi.Start();
            bmw.Stop();

            Console.WriteLine("\n----------------------------------------------\n");

            audi.Brake(35);
            bmw.Accelerate(45);

            Console.WriteLine("\n----------------------------------------------\n");

            audi.DisplayInfo();
            bmw.DisplayInfo();

            Console.ReadLine();
        }
    }
}