
namespace Solver
{
    using System;

    public static class KundtFunctions
    {
        private const double DefaultAtmosphericPressure = 101.32F;

        public static double Amplitude(double c1, double c2)
        {
            double rCalculate = 0;



            return rCalculate;
        }

        public static double SoundVelocity(double temperature)
        {
            double rCalculate = 0;
            rCalculate = 20.047 * (Math.Sqrt(273.15 + temperature));
            return rCalculate;
        }

        //ok
        public static double WaveNumber(double frequency, double temperature)
        {
            double rCalculate = 0;
            double soundVelocity = SoundVelocity(temperature);
            if (soundVelocity == 0) { return 0; }
            rCalculate = (2 * Math.PI * frequency) / soundVelocity;
            return rCalculate;
        }

        //ok
        public static double AirDensity(double temperature, double? pressure = null)
        {
            double rCalculate = 0;
            double AtmosphericPressure = pressure ?? DefaultAtmosphericPressure;
            rCalculate = 1.290 * (AtmosphericPressure / 101.325) * (273.15 / (273.15 + temperature));
            return rCalculate;
        }

        //ok
        public static double TFFixed(double mic1, double mic2)
        {
            double rCalculate = 0;
            double m1 = 0, m2=0;
            m1 = Math.Sqrt(Math.Pow(mic1, 2) );
            m2 = Math.Sqrt(Math.Pow(mic2, 2));
            rCalculate = Math.Sqrt( ( m1 * m2 ) );
            return rCalculate;
        }
    }
}
