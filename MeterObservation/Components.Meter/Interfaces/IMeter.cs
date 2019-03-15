namespace Components.Meter.Interfaces
{
    /// <summary>
    /// <para>An interface for a meter.</para>
    /// </summary>
    public interface IMeter
    {
        /// <summary>
        /// <para>Get the actual meter count.</para>
        /// </summary>
        double ActualMeterCount { get; }

        /// <summary>
        /// <para>Transmit <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">A meter count</param>
        void TransmitMeterCount(double meterCount);

        /// <summary>
        /// <para>Display <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">A meter count</param>
        void DisplayMeterCount(double meterCount);
    }
}
