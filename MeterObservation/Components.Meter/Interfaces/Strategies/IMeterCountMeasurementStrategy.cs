namespace Components.Meter.Interfaces.Strategies
{
    /// <summary>
    /// <para>An interface for a strategy that measures a meter count.</para>
    /// </summary>
    public interface IMeterCountMeasurementStrategy
    {
        /// <summary>
        /// <para>Get the actual meter count.</para>
        /// </summary>
        /// <returns>The actual meter count</returns>
        string GetActualMeterCount();
    }
}
