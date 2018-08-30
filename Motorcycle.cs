using System;

namespace interfaces
{
    public class Motorcycle : IVehicle, ILand
    {
        public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
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