using System;
using Components.Meter.Interfaces.Strategies;

namespace MeterObservation.DisplayStrategies
{
    internal class ScaleDisplay : IMeterCountDisplayStrategy
    {
        /// <summary>
        /// <see cref="IMeterCountDisplayStrategy.DisplayMeterCount(string)"/>
        /// </summary>
        /// <param name="meterCount"></param>
        public void DisplayMeterCount(string meterCount)
        {
            Console.WriteLine(string.Format("Display {0} on a scale display", meterCount));
        }
    }
}
