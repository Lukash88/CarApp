namespace CarApp
{
    public interface ICarService : IBaseVehicle
    {
        public Transmission Transmission { get; set; }
        void StartEngine();
        void StopEngine();
        void DisplayCarInfo();
    }
}