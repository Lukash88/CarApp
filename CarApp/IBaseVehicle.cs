namespace CarApp
{
    public interface IBaseVehicle
    {
        void SpeedUp(string brand, string model, int speed, int maxSpeed, int acceleration);
        void SlowDown(string brand, string model, int speed, int maxSpeed, int deceleration);
        void Turn(string brand, string model, string direction);
    }
}