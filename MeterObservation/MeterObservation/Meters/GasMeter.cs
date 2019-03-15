using Components.Meter;
using Components.Meter.Interfaces.Strategies;

namespace MeterObservation.Meters
{
    internal class GasMeter : AbstractMeter
    {
        public GasMeter(
            IMeterCountMeasurementStrategy meterCountDeterminationStrategy,
            IMeterCountDisplayStrategy meterCountDisplayStrategy,
            IMeterCountTransmissionStrategy meterCountTransmissionStrategy)
            : base(meterCountDeterminationStrategy, meterCountDisplayStrategy, meterCountTransmissionStrategy)
        {
        }
    }
}
