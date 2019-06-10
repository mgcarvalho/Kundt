namespace UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Solver;

    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void Alplitude_Ok()
        {
            //Arrange
            double c1 = 0;
            double c2 = 0;
            double expected = 10;

            //Act
            double result = KundtFunctions.Amplitude(c1, c2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SoundVelocity_Ok()
        {
            //Arrange
            double c1 = 0;
            double expected = 10;

            //Act
            double result = KundtFunctions.SoundVelocity(c1);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WaveNumber_Ok()
        {
            //Arrange
            double c1 = 0;
            double c2 = 0;
            double expected = 10;

            //Act
            double result = KundtFunctions.WaveNumber(c1, c2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AirDensity_Ok()
        {
            //Arrange
            double c1 = 0;
            double c2 = 0;
            double expected = 10;

            //Act
            double result = KundtFunctions.AirDensity(c1, c2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AirDensity_NullPressure_Ok()
        {
            //Arrange
            double c1 = 0;
            double expected = 10;

            //Act
            double result = KundtFunctions.AirDensity(c1, null);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
