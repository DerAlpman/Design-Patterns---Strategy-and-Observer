namespace Components.Meter.Interfaces.Strategies
{
    /// <summary>
    /// <para>An interface for a strategy that determines a meter count.</para>
    /// </summary>
    public interface IMeterCountDeterminationStrategy
    {
        /// <summary>
        /// <para>Get the actual meter count.</para>
        /// </summary>
        /// <returns>The actual meter count</returns>
        double GetActualMeterCount();
    }
}
