using System;
using Components.Meter.Interfaces.Strategies;

namespace Components.Meter
{
    /// <summary>
    /// <para>Abstract class for strategy for measuring meter counts.</para>
    /// </summary>
    public abstract class AbstractMeterCountMeasurementStrategy : IMeterCountMeasurementStrategy
    {
        #region IMeterCountMeasurementStrategy

        /// <summary>
        /// <see cref="IMeterCountMeasurementStrategy.GetActualMeterCount"/>
        /// </summary>
        /// <returns></returns>
        public string GetActualMeterCount()
        {
            string meterCount = MeasuredMeterCount();

            Console.WriteLine(string.Format("Measuring the meter count {0} with a {1}.", meterCount, this.GetType().Name));

            return meterCount;
        }

        #endregion

        private string MeasuredMeterCount()
        {
            Random meterCountGenerator = new Random();

            return (meterCountGenerator.NextDouble() * 1000).ToString("N3");
        }
    }
}
