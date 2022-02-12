using PreWorkMidTerm;
using NUnit.Framework;

namespace PreWorkMidTerm
{
    public class PixelPerInchTest
    {
        [Test]
        public void Test1()
        {
            //arrange
            int width = 45;
            int height = 65;
            double diagnol = 5.5;

            double expectedPPI = 14.37;
            double expectedDiagnol = 79.06;
            double dotPitchExpected = 1.7671;

            //act
            PixelCal.ppiCalculation(height, width, diagnol);

            //assert
            Assert.AreEqual(expectedPPI, PixelCal.ppi);
            //Assert.AreEqual(expectedDiagnol, PixelCal.diagnolPixels);
            Assert.AreEqual(dotPitchExpected, PixelCal.dotPitch);

        }

        [Test]
        public void Test2()
        {
            //arrange
            int width = 78;
            int height = 67;
            double diagnol = 1.2;

            double expectedPPI = 85.69;
            double expectedDiagnol = 102.83;
            double expectedDotPitch = 0.2964;

            //act
            PixelCal.ppiCalculation(height, width, diagnol);

            //assert
            Assert.AreEqual(expectedPPI, PixelCal.ppi);
            //Assert.AreEqual(expectedDiagnol, PixelCal.diagnolPixels);
            Assert.AreEqual(expectedDotPitch, PixelCal.dotPitch);
        }

        [Test]
        public void Test3()
        {
            //arrange
            int width = 89;
            int height = 98;
            double diagnol = 4.369;

            double expectedPPI = 30.3;
            double expectedDiagnol = 132.38;
            double expectedDotPitch = 0.8383;

            //act
            PixelCal.ppiCalculation(height, width, diagnol);

            //assert
            Assert.AreEqual(expectedPPI, PixelCal.ppi);
            //Assert.AreEqual(expectedDiagnol, PixelCal.diagnolPixels);
            Assert.AreEqual(expectedDotPitch, PixelCal.dotPitch);
        }

        [Test]
        public void Test4()
        {
            //arrange
            int width = 65;
            int height = 45;
            double diagnol = 2.0002;

            double expectedPPI = 39.52;
            double expectedDiagnol = 79.06;
            double expectedDotPitch = 0.6426;

            //act
            PixelCal.ppiCalculation(height, width, diagnol);

            //assert
            Assert.AreEqual(expectedPPI, PixelCal.ppi);
           // Assert.AreEqual(expectedDiagnol, PixelCal.diagnolPixels);
            Assert.AreEqual(expectedDotPitch, PixelCal.dotPitch);

        }

        [Test]
        public void Test5()
        {
            //arrange
            int width = 21;
            int height = 13;
            double diagnol = 9.9999;

            double expectedPPI = 2.47;
            double expectedDiagnol = 24.7;
            double expectedDotPitch = 10.2841;

            //act
            PixelCal.ppiCalculation(height, width, diagnol);

            //assert
            Assert.AreEqual(expectedPPI, PixelCal.ppi);
           // Assert.AreEqual(expectedDiagnol, PixelCal.diagnolPixels);
            Assert.AreEqual(expectedDotPitch, PixelCal.dotPitch);

        }
    }
}