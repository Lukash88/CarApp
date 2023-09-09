namespace CarApp
{
    public class Car
    {
        private readonly ICarService _carService = new CarService();

        public Car(string brand, string model, int speed, int maxSpeed, Transmission transmission)
        {
            _carService.MaxSpeed = maxSpeed;
            _carService.Brand = brand;
            _carService.Model = model;
            _carService.Speed = speed;
            _carService.Transmission = transmission;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; } = 0;
        public int MaxSpeed { get; set; }
        public Transmission Transmission { get; set; }

        public void Start()
        {
            _carService.StartEngine();
        }

        public void Stop()
        {
            _carService.StopEngine();
        }

        public void Accelerate(int acceleration)
        {
            _carService.SpeedUp(acceleration);
        }

        public void Brake(int deceleration)
        {
            _carService.SlowDown(deceleration);
        }

        public void Turn(string direction)
        {
            _carService.Turn(direction);
        }

        public void DisplayInfo()
        {
            _carService.DisplayCarInfo();
        }
    }
}