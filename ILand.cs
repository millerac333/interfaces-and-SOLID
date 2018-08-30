public interface ILand
{
    string TransmissionType { get; set; }
    int Wheels { get; set; }
    int Doors { get; set; }
    double MaxLandSpeed { get; set; }
    void Drive();
};