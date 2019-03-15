using Components.Meter.Interfaces;
using Components.Meter.Interfaces.Strategies;

namespace Components.Meter
{
    /// <summary>
    /// <para>Abstract base class for a meter.</para>
    /// </summary>
    public abstract class AbstractMeter : IMeter
    {
        #region FIELDS

        private IMeterCountMeasurementStrategy _MeterCountDeterminationStrategy;
        private IMeterCountDisplayStrategy _MeterCountDisplayStrategy;
        private IMeterCountTransmissionStrategy _MeterCountTransmissionStrategy;

        #endregion

        #region CONSTRUCTOR
        public AbstractMeter(
            IMeterCountMeasurementStrategy meterCountDeterminationStrategy,
            IMeterCountDisplayStrategy meterCountDisplayStrategy,
            IMeterCountTransmissionStrategy meterCountTransmissionStrategy)
        {
            this._MeterCountDeterminationStrategy = meterCountDeterminationStrategy;
            this._MeterCountDisplayStrategy = meterCountDisplayStrategy;
            this._MeterCountTransmissionStrategy = meterCountTransmissionStrategy;
        }

        #endregion

        #region IMeter

        /// <summary>
        /// <see cref="IMeter.ActualMeterCount"/>
        /// </summary>
        public string ActualMeterCount => MeterCountDeterminationStrategy.GetActualMeterCount();

        /// <summary>
        /// <see cref="IMeter.MeterCountDeterminationStrategy"/>
        /// </summary>
        public IMeterCountMeasurementStrategy MeterCountDeterminationStrategy { get => _MeterCountDeterminationStrategy; set => _MeterCountDeterminationStrategy = value; }

        /// <summary>
        /// <see cref="IMeter.MeterCountDisplayStrategy"/>
        /// </summary>
        public IMeterCountDisplayStrategy MeterCountDisplayStrategy { get => _MeterCountDisplayStrategy; set => _MeterCountDisplayStrategy = value; }

        /// <summary>
        /// <see cref="IMeter.MeterCountTransmissionStrategy"/>
        /// </summary>
        public IMeterCountTransmissionStrategy MeterCountTransmissionStrategy { get => _MeterCountTransmissionStrategy; set => _MeterCountTransmissionStrategy = value; }

        /// <summary>
        /// <see cref="IMeter.DisplayMeterCount(string)"/>
        /// </summary>
        /// <param name="meterCount"></param>
        public void DisplayMeterCount(string meterCount)
        {
            MeterCountDisplayStrategy.DisplayMeterCount(meterCount);
        }

        /// <summary>
        /// <see cref="IMeter.TransmitMeterCount(string)"/>
        /// </summary>
        /// <param name="meterCount"></param>
        public void TransmitMeterCount(string meterCount)
        {
            MeterCountTransmissionStrategy.TransmitMeterCount(meterCount);
        }

        #endregion
    }
}
