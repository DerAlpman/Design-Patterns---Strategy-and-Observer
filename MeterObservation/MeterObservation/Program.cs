using System;
using Components.Meter;
using Components.Meter.Interfaces.Strategies;
using MeterObservation.DataDeterminationStrategies;
using MeterObservation.DisplayStrategies;
using MeterObservation.Meters;
using MeterObservation.TransmissionStrategies;

namespace MeterObservation
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            AbstractMeterCountMeasurementStrategy rpMeasurement = new RotaryPistonMeasurement();
            AbstractMeterCountMeasurementStrategy usMeasurement = new UltraSoundMeasurement();

            IMeterCountDisplayStrategy led = new LEDDisplay();
            IMeterCountDisplayStrategy scale = new ScaleDisplay();

            IMeterCountTransmissionStrategy wlan = new WLANTransmission();
            IMeterCountTransmissionStrategy cable = new CableTransmission();

            AbstractMeter meter = new GasMeter(rpMeasurement, led, cable);

            string meterCount = meter.ActualMeterCount;

            meter.DisplayMeterCount(meterCount);
            meter.TransmitMeterCount(meterCount);

            Console.ReadKey();
        }
    }
}
