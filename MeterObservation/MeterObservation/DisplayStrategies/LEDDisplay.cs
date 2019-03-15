using System;
using Components.Meter.Interfaces.Strategies;

namespace MeterObservation.DisplayStrategies
{
    internal class LEDDisplay : IMeterCountDisplayStrategy
    {
        /// <summary>
        /// <see cref="IMeterCountDisplayStrategy.DisplayMeterCount(string)"/>
        /// </summary>
        /// <param name="meterCount"></param>
        public void DisplayMeterCount(string meterCount)
        {
            Console.WriteLine(string.Format("Display {0} on an LED display", meterCount));
        }
    }
}
