using System;
using System.Linq;
using System.Collections.Generic;
public interface IVehicle
{
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}