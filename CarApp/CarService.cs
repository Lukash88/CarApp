namespace CarApp
{
    public class CarService : ICarService
    {
        public void StartEngine(string brand, string model)
        {
            Console.WriteLine($"Your {brand} {model} started the engine.\n");
        }

        public void StopEngine(string brand, string model)
        {
            Console.WriteLine($"Your {brand} {model} stoped the engine.\n");
        }

        public void SpeedUp(string brand, string model, int speed, int maxSpeed, int acceleration)
        {
            if (speed == 0)
            {
                speed += acceleration;
                if (speed >= maxSpeed)
                {
                    speed = maxSpeed;
                    Console.WriteLine($"You just started to drive and you have just reached your max speed: " +
                                      $"{speed} - {maxSpeed} of your {brand} {model}.\n");
                }
                else
                {
                    Console.WriteLine($"You just started to drive, your current speed is {speed} " +
                                      $"with your {brand} {model}.\n");
                }
            }
            else
            {
                speed += acceleration;
                if (speed >= maxSpeed)
                {
                    speed = maxSpeed;
                    Console.WriteLine($"You have just reached your max speed: {speed} - {maxSpeed} " +
                                      $"of your {brand} {model}.\n");
                }
                else
                {
                    Console.WriteLine($"You sped up to {speed} with your {brand} {model}.\n");
                }
            }
        }

        public void SlowDown(string brand, string model, int speed, int maxSpeed, int deceleration)
        {
            if (speed == 0)
            {
                Console.WriteLine($"You have already stopped driving your {brand} {model}.\n");
            }
            else
            {
                speed -= deceleration;
                if (speed <= 0)
                {
                    speed = 0;
                    Console.WriteLine($"You have just stopped your {brand} {model}.\n");
                }
                else
                {
                    Console.WriteLine($"You slowed down to {speed} with your {brand} {model}.\n");
                }
            }
        }

        public void Turn(string brand, string model, string direction)
        {
            Console.WriteLine($"Your {brand} {model} is turning to the {direction}.\n");
        }

        public void DisplayCarInfo(string brand, string model, Transmission transmission, int speed, int maxSpeed)
        {
            Console.WriteLine("Your car info:");

            Console.WriteLine($"\t- Brand: {brand}");
            Console.WriteLine($"\t- Model: {model}");
            Console.WriteLine($"\t- Transmission: {transmission.Type} - {transmission.NumberOfGears} gears");
            Console.WriteLine($"\t- Your current speed: {speed}");
            Console.WriteLine($"\t- Your max speed: {maxSpeed}\n");
        }
    }
}