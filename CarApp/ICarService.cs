namespace CarApp
{
    public interface ICarService : IBaseVehicle
    {
        void StartEngine(string brand, string model);
        void StopEngine(string brand, string model);
        void DisplayCarInfo(string brand, string model, Transmission transmission, int speed, int maxSpeed);
    }
}