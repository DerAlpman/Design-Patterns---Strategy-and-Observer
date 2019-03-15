namespace Components.Meter.Interfaces.Strategies
{
    /// <summary>
    /// <para>An interface for a strategy that transmits a meter count.</para>
    /// </summary>
    public interface IMeterCountTransmissionStrategy
    {
        /// <summary>
        /// <para>Transmits <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">A meter count</param>
        void TransmitMeterCount(double meterCount);
    }
}
