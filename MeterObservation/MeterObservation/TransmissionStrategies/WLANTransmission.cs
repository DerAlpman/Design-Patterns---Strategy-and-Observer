using System;
using Components.Meter.Interfaces.Strategies;

namespace MeterObservation.TransmissionStrategies
{
    internal class WLANTransmission : IMeterCountTransmissionStrategy
    {
        #region IMeterCountTransmissionStrategy

        /// <summary>
        /// <see cref="IMeterCountTransmissionStrategy.TransmitMeterCount(string)"/>
        /// </summary>
        /// <param name="meterCount"></param>
        public void TransmitMeterCount(string meterCount)
        {
            Console.WriteLine(string.Format("Transmitting {0} via WLAN.", meterCount));
        }

        #endregion
    }
}
