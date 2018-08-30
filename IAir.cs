public interface IAir
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
    void Fly();

};