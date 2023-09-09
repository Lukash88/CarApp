namespace CarApp
{
    public class CarService : ICarService
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; } = 0;
        public int MaxSpeed { get; set; }
        public Transmission Transmission { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"Your {Brand} {Model} started the engine.\n");
        }

        public void StopEngine()
        {
            Console.WriteLine($"Your {Brand} {Model} stooped the engine.\n");
        }

        public void SpeedUp(int acceleration)
        {
            if (Speed == 0)
            {
                Speed += acceleration;
                if (Speed >= MaxSpeed)
                {
                    Speed = MaxSpeed;
                    Console.WriteLine($"You just started to drive and you have just reached your max speed: " +
                                      $"{Speed} - {MaxSpeed} of your {Brand} {Model}.\n");
                }
                else
                {
                    Console.WriteLine($"You just started to drive, your current speed is {Speed} " +
                                      $"with your {Brand} {Model}.\n");
                }
            }
            else
            {
                Speed += acceleration;
                if (Speed >= MaxSpeed)
                {
                    Speed = MaxSpeed;
                    Console.WriteLine($"You have just reached your max speed: {Speed} - {MaxSpeed} " +
                                      $"of your {Brand} {Model}.\n");
                }
                else
                {
                    Console.WriteLine($"You sped up to {Speed} with your {Brand} {Model}.\n");
                }
            }
        }

        public void SlowDown(int deceleration)
        {
            if (Speed == 0)
            {
                Console.WriteLine($"You have already stopped driving your {Brand} {Model}.\n");
            }
            else
            {
                Speed -= deceleration;
                if (Speed <= 0)
                {
                    Speed = 0;
                    Console.WriteLine($"You have just stopped your {Brand} {Model}.\n");
                }
                else
                {
                    Console.WriteLine($"You slowed down to {Speed} with your {Brand} {Model}.\n");
                }
            }
        }

        public void Turn(string direction)
        {
            Console.WriteLine($"Your {Brand} {Model} turning to the {direction}.\n");
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("Your car info:");
            Console.WriteLine($"\t- Brand: {Brand}");
            Console.WriteLine($"\t- Model: {Model}");
            Console.WriteLine($"\t- Transmission: {Transmission.Type} - {Transmission.NumberOfGears} gears");
            Console.WriteLine($"\t- Your current speed: {Speed}");
            Console.WriteLine($"\t- Your max speed: {MaxSpeed}\n");
        }
    }
}