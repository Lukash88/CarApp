namespace CarApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tWelcome to the CarApp\n");
            Console.ResetColor();

            var audi = new Car("Audi", "A6", 90, 200,
                new Transmission("Automatic", 7));
            var bmw = new Car("BMW", "X5", 100, 190,
                new Transmission("Manual", 6));

            audi.DisplayInfo();
            audi.Start();
            audi.Accelerate(200);
            audi.Brake(35);
            audi.Turn("left");
            audi.Stop();
            audi.DisplayInfo();

            Console.WriteLine("\n----------------------------------------------\n");

            bmw.DisplayInfo();
            bmw.Start();
            bmw.Accelerate(45);
            bmw.Turn("right");
            bmw.Brake(1000);
            bmw.Stop();
            bmw.DisplayInfo();

            Console.ReadLine();
        }
    }
}