namespace CarApp
{
    public class Transmission
    {
        public Transmission(string type, int numberOfGears)
        {
            Type = type;
            NumberOfGears = numberOfGears;
        }

        public string Type { get; }
        public int NumberOfGears { get; }
    }
}