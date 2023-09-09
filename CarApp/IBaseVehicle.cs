namespace CarApp
{
    public interface IBaseVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }

        void SpeedUp(int acceleration);
        void SlowDown(int deceleration);
        void Turn(string direction);
    }
}