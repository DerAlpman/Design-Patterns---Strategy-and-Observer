﻿namespace Components.Meter.Interfaces.Strategies
{
    /// <summary>
    /// <para>An interface for a strategy that displays a meter count.</para>
    /// </summary>
    public interface IMeterCountDisplayStrategy
    {
        /// <summary>
        /// <para>Displays <paramref name="meterCount"/>.</para>
        /// </summary>
        /// <param name="meterCount">A meter count</param>
        void DisplayMeterCount(string meterCount);
    }
}
