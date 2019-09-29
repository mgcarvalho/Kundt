namespace UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DTO;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class MeasurementTest
    {
        [TestMethod]
        public void SimplyMeasurement_Ok()
        {
            //Arrange
            Measurement m = new Measurement();
            DataMeasurement dM = new DataMeasurement();
            Mic c1 = new Mic();
            Mic c2 = new Mic();

            FRF m1 = new FRF();
            FRF m2 = new FRF();

            FFT m3 = new FFT();
            FFT m4 = new FFT();


            //Act
            c1.Time = 0;
            c1.Pressure = -1.47F;

            c2.Time = 0;
            c2.Pressure = 0.59F;

            m1.Frequency = 0;
            m1.Amplification = 0;

            m2.Frequency = 0;
            m2.Amplification = 0;

            m3.Frequency = 0;
            m3.Amplitude = 0;

            m4.Frequency = 0;
            m4.Amplitude = 0;

            dM.Id = 1;
            dM.C1 = c1;
            dM.C2 = c2;

            dM.M1 = m1;
            dM.M2 = m2;
            dM.M3 = m3;
            dM.M4 = m4;

            
            m.Id = new System.Guid();
            m.Date = new System.DateTime(2019, 04, 08, 14, 45, 34);

            m.Temperature = 15;
            m.AtmosphericPressure = 0;

            //m.Measurements.Add(dM);

            //Assert
            //Assert.AreEqual(1, m.Measurements.Count);
            //Assert.AreEqual(0, m.Measurements.First().M3.Frequency);
            //Assert.AreEqual(-1.47F, m.Measurements.First().C1.Pressure);

        }
    }
}
