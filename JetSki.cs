using System;

namespace interfaces
{
    public class JetSki : IVehicle, IAquatic
    {
        public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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