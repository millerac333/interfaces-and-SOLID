using System;

namespace interfaces
{
    public class Cessna : IVehicle, IAir
    {
        public int PassengerCapacity { get; set; } = 3;
        public double EngineVolume { get; set; } = 31.3;
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public bool Winged { get; set; } = true;
        public double MaxAirSpeedMPH { get; set; } = 188;

        public void Fly()
        {
            Console.WriteLine("The Cessna is a small, privite airplane is built in Witchita, Kansas.");
        }
        public void Start()
        {
            Console.WriteLine("The Cessna is powered by a piston engine.");
        }
        public void Stop()
        {
            Console.WriteLine("One must first land a Cessna before it stops.");
        }
    }
}