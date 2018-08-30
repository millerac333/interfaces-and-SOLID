using System;

namespace interfaces
{
    public class Motorcycle : IVehicle, ILand
    {
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Manual or Automatic";
        public double EngineVolume { get; set; } = 600;
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public double MaxLandSpeed { get; set; } = 202.5;

        public void Drive()
        {
            Console.WriteLine("Motorcycles lack doors which makes it easier to fall off and scratch a knee.");
        }

        public void Start()
        {
            Console.WriteLine("There are no pedals on Motorcycles; one uses a throttle to start and ride and must not forget to retract the kickstand");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycles use brakes or large, solid objects to stop.");
        }
    }
}