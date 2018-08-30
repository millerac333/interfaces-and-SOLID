using System;

namespace interfaces
{
    public class Cessna : IVehicle, IAir
    {
        public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}