
namespace Solver
{
    using System;
    using System.Numerics;


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


        public static double TransferFunction(double mic1, double mic2)
        {
            return Math.Sqrt((mic1 * mic2)); ;
        }

        public static double Ks(double frequency, double temperature, double micDistance)
        {
            double k = WaveNumber(frequency, temperature);
            return k * micDistance;
        }

        public static double Kx(double frequency, double temperature, double furtherMicrophone)
        {
            double k = WaveNumber(frequency, temperature);
            return 2 * k * furtherMicrophone;
        }

        public static Complex Hi(double frequency, double temperature, double micDistance)
        {
            double ks = Ks(frequency, temperature, micDistance);
            double real = Math.Cos(ks);
            double imaginary = -1 * Math.Sin(ks);
            return new Complex(real, imaginary);
        }

        public static Complex Hr(double frequency, double temperature, double micDistance)
        {
            double ks = Ks(frequency, temperature, micDistance);
            double real = Math.Cos(ks);
            double imaginary = Math.Sin(ks);
            return new Complex(real, imaginary);
        }

        public static Complex E2(double frequency, double temperature, double furtherMicrophone)
        {
            double kx = Kx(frequency, temperature, furtherMicrophone);
            double real = Math.Cos(2 * kx);
            double imaginary = Math.Sin(2 * kx);
            return new Complex(real, imaginary);
        }

        public static double Reflection(double transferFunction, double frequency, double temperature, double micDistance, double furtherMicrophone)
        {
            Complex hi = Hi(frequency, temperature, micDistance);
            Complex hr = Hr(frequency, temperature, micDistance);
            Complex e2 = E2(frequency, temperature, furtherMicrophone);

            double topReal = transferFunction - hi.Real;
            double bottonReal = hr.Real - transferFunction;
            double topImaginary = transferFunction - hi.Imaginary;
            double bottonImaginary = hr.Imaginary - transferFunction;

            Complex top = Complex.Multiply(new Complex(topReal, topImaginary), e2);
            Complex botton = new Complex(bottonReal, bottonImaginary);

            Complex r = Complex.Divide(top, botton);
            return Complex.Abs(r);
        }

        public static double Absorption(double reflection)
        {
            return 1 - (Math.Pow(reflection, 2));
        }

        public static double Impedance(double reflection)
        {
            double top = 1 + reflection;
            double botton = 1 - reflection;
            return top / botton;
        }

    }
}
