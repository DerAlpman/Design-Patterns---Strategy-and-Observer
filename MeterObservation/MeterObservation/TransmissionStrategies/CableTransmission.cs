using System;
using Components.Meter.Interfaces.Strategies;

namespace MeterObservation.TransmissionStrategies
{
    internal class CableTransmission : IMeterCountTransmissionStrategy
    {
        /// <summary>
        /// <see cref="IMeterCountTransmissionStrategy.TransmitMeterCount(string)"/>
        /// </summary>
        /// <param name="meterCount"></param>
        public void TransmitMeterCount(string meterCount)
        {
            Console.WriteLine(string.Format("Transmitting {0} via Cable.", meterCount));
        }
    }
}
