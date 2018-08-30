public interface IAir
{
    int Wheels { get; set; }
    int Doors { get; set; }
    bool Winged { get; set; }
    double MaxAirSpeedMPH { get; set; }
    void Fly();
};