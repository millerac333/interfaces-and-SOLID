public interface IVehicle
{
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}