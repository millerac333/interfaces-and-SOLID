public interface IAquatic
{
    string TransmissionType { get; set; }
    double MaxWaterSpeed { get; set; }
    void Drive();
};