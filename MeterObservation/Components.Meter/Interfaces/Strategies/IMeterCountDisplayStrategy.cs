namespace Components.Meter.Interfaces.Strategies
{
    /// <summary>
    /// <para>An interface for a strategy that displays a meter count.</para>
    /// </summary>
    public interface IMeterCountDisplayStrategy
    {
        /// <summary>
        /// <para>Displays <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">The meter count</param>
        void DisplayMeterCount(double meterCount);
    }
}
