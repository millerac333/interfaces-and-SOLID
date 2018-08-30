using System;

namespace interfaces
{
    public class JetSki : IVehicle, IAquatic
    {
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; } = 3;
        public double MaxWaterSpeed { get; set; } = 70;

        public void Drive()
        {
            Console.WriteLine("JetSkis must be used in liquid H2O and not on frozen H20 or snow; one will not get very far when using a JetSki in the snow.");
        }

        public void Start()
        {
            Console.WriteLine("Jetskis tend to get wet.");
        }

        public void Stop()
        {
            Console.WriteLine("Simply jump off the Jetski to stop.");
        }
    }
}