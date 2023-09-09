namespace CarApp
{
    public class Car
    {
        private readonly ICarService _carService = new CarService();
        private readonly string _brand;
        private readonly string _model;
        private readonly int _speed = 0;
        private readonly int _maxSpeed;
        private readonly Transmission _transmission;

        public Car(string brand, string model, int speed, int maxSpeed, Transmission transmission)
        {
            _maxSpeed = maxSpeed;
            _brand = brand;
            _model = model;
            _speed = speed;
            _transmission = transmission;
        }

        public void Start()
        {
            _carService.StartEngine(_brand, _model);
        }

        public void Stop()
        {
            _carService.StopEngine(_brand, _model);
        }

        public void Accelerate(int acceleration)
        {
            _carService.SpeedUp(_brand, _model, _speed, _maxSpeed, acceleration);
        }

        public void Brake(int deceleration)
        {
            _carService.SlowDown(_brand, _model, _speed, _maxSpeed, deceleration);
        }

        public void Turn(string direction)
        {
            _carService.Turn(_brand, _model, direction);
        }

        public void DisplayInfo()
        {
            _carService.DisplayCarInfo(_brand, _model, _transmission, _speed, _maxSpeed);
        }
    }
}