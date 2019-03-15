using Components.Meter.Interfaces.Strategies;

namespace Components.Meter.Interfaces
{
    /// <summary>
    /// <para>An interface for a meter.</para>
    /// </summary>
    public interface IMeter
    {
        /// <summary>
        /// <para>Get or set <see cref="IMeterCountMeasurementStrategy"/></para>
        /// </summary>
        IMeterCountMeasurementStrategy MeterCountDeterminationStrategy { get; set; }

        /// <summary>
        /// <para>Get or set <see cref="IMeterCountDisplayStrategy"/></para>
        /// </summary>
        IMeterCountDisplayStrategy MeterCountDisplayStrategy { get; set; }

        /// <summary>
        /// <para>Get or set <see cref="IMeterCountTransmissionStrategy"/></para>
        /// </summary>
        IMeterCountTransmissionStrategy MeterCountTransmissionStrategy { get; set; }

        /// <summary>
        /// <para>Get the actual meter count.</para>
        /// </summary>
        string ActualMeterCount { get; }

        /// <summary>
        /// <para>Transmit <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">A meter count</param>
        void TransmitMeterCount(string meterCount);

        /// <summary>
        /// <para>Display <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">A meter count</param>
        void DisplayMeterCount(string meterCount);
    }
}
