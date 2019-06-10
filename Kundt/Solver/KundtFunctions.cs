
namespace Solver
{
    using System;

    public static class KundtFunctions
    {
        private const double DefaultAtmosphericPressure = 1.05F;

        public static double Amplitude(double c1, double c2)
        {
            double rCalculate = 0;



            return rCalculate;
        }

        public static double SoundVelocity(double temper)
        {
            double rCalculate = 0;
            rCalculate = 20.047 * (Math.Sqrt(273.15 + temper));
            return rCalculate;
        }

        //ok
        public static double WaveNumber(double frequency, double temper)
        {
            double rCalculate = 0;
            double soundVelocity = SoundVelocity(temper);
            if (soundVelocity == 0) { return 0; }
            rCalculate = (2 * Math.PI * frequency) / soundVelocity; 
            return rCalculate;
        }

        //ok
        public static double AirDensity(double temper, double? pressure = null)
        {
            double rCalculate = 0;
            double AtmosphericPressure = pressure ?? DefaultAtmosphericPressure;
            rCalculate = 1.290 * (AtmosphericPressure / 101.325) * (273.15 / (273.15 + temper));
            return rCalculate;
        }
    }
}
