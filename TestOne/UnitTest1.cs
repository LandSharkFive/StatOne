using StatOne;

namespace TestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVar1()
        {
            double[] a  = { 4, 4, 5, 6, 7, 8, 9, 10, 21, 46, 86 };

            double variance = a.Variance();
            Assert.AreEqual(589.289256198, variance, 1e-6);
        }

        [TestMethod]
        public void TestVar2()
        {
            double[] a  = { 6, 8, 10, 22, 35, 54 };

            double variance = a.Variance();
            Assert.AreEqual(297.91666666, variance, 1e-6);
        }

        [TestMethod]
        public void TestSD1()
        {
            double[] a  = { 3, 8, 10, 21, 36, 54 };

            double std = a.StandardDeviation();
            Assert.AreEqual(17.897858344, std, 1e-6);
        }

        [TestMethod]
        public void TestSD2()
        {
            double[] a  = { 10, 15, 22, 32, 48 };

            double std = a.StandardDeviation();
            Assert.AreEqual(13.499629624, std, 1e-6);
        }

        [TestMethod]
        public void TestCoVar1()
        {
            double[] a = { 10, 17, 27, 32, 48 };
            double[] b = { 11, 15, 25, 30, 47 };

            double cov = Util.Covariance(a, b);
            Assert.AreEqual(165.12, cov);
        }

        [TestMethod]
        public void TestCoVar2()
        {
            double[] a = { 6, 12, 21, 30, 47 };
            double[] b = { 5, 11, 20, 30, 50 };

            double cov = Util.Covariance(a, b);
            Assert.AreEqual(228.16, cov);
        }

        [TestMethod]
        public void TestPearson1()
        {
            double[] a = { 6, 12, 21, 30, 47 };
            double[] b = { 5, 11, 20, 30, 50 };

            double pr = Util.Pearson(a, b);
            Assert.AreEqual(0.999208847, pr, 1e-5);
        }

        [TestMethod]
        public void TestPearson2()
        {
            double[] a = { 9, 10, 15, 19, 25 };
            double[] b = { 5, 11, 16, 22, 29 };

            double pr = Util.Pearson(a, b);
            Assert.AreEqual(0.983239692, pr, 1e-5);
        }

        [TestMethod]
        public void TestSlope1()
        {
            double[] dx = { 9, 15, 25 };
            double[] dy = { 10, 19, 29 };

            double y = 0;
            double slope = Util.GetSlopeIntercept(dx, dy, out y);
            Assert.AreEqual(1.168367343, slope, 1e-5);
            Assert.AreEqual(0.25, y);
        }

        [TestMethod]
        public void TestSlope2()
        {
            double[] dx = { 9, 15, 25 };
            double[] dy = { 5, 29, 43 };

            double y = 0;
            double slope= Util.GetSlopeIntercept(dx, dy, out y);
            Assert.AreEqual(2.275510204, slope, 1e-5);
            Assert.AreEqual(-11.5, y);
        }

        [TestMethod]
        public void TestCor1()
        {
            double[] dx = { 4, 4, 5, 6, 7, 8, 9, 10, 21, 46, 86 };
            double[] dy = { 5, 3, 5, 7, 8, 10, 9, 11, 22, 45, 84 };

            double cor = Util.Correlation(dx, dy);
            Assert.AreEqual(0.999414388, cor, 1e-5);
        }

        [TestMethod]
        public void TestCor2()
        {
            double[] dx = { 3, 5, 7, 9, 11, 15, 31, 42 };
            double[] dy = { 4, 5, 8, 10, 12, 11, 29, 45 };

            double cor = Util.Correlation(dx, dy);
            Assert.AreEqual(0.988399162, cor, 1e-5);
        }

        [TestMethod]
        public void TestRSquare1()
        {
            double[] dx = { 7, 10, 11, 13, 15, 22 };
            double[] dy = { 6, 12, 13, 14, 17, 23 };

            double r2 = Util.RSquared(dx, dy);
            Assert.AreEqual(0.960783699, r2, 1e-5);
        }

        [TestMethod]
        public void TestRSquare2()
        {
            double[] dx = { 2, 4, 9, 13, 15, 22, 32 };
            double[] dy = { 4, 6, 8, 15, 18, 25, 30 };

            double r2 = Util.RSquared(dx, dy);
            Assert.AreEqual(0.9660998, r2, 1e-5);
        }

        [TestMethod]
        public void TestRSquare3()
        {
            double r2 = Util.RSquared(0.915954468);
            Assert.AreEqual(0.83897258, r2, 1e-5);
        }

        [TestMethod]
        public void TestChi1()
        {
            double[] a = { 2, 3, 4, 5, 7, 12, 14 };
            double[] b = { 1, 3, 5, 7, 9, 11, 12 };

            double x2 = Util.ChiSquared(a, b);
            Assert.AreEqual(2.64011544, x2, 1e-5);
        }

        [TestMethod]
        public void TestChi2()
        {
            double[] a = { 3, 5, 6, 8, 9, 10 };
            double[] b = { 3, 5, 7, 8, 8, 12 };

            double x2 = Util.ChiSquared(a, b);
            Assert.AreEqual(0.601190476, x2, 1e-5);
        }

        [TestMethod]
        public void TestPhi1()
        {
            Assert.AreEqual(0.0013498, Util.Phi(-3), 1e-5);
            Assert.AreEqual(0.1586552, Util.Phi(-1), 1e-5);
            Assert.AreEqual(0.5, Util.Phi(0), 1e-5);
            Assert.AreEqual(0.6914624, Util.Phi(0.5), 1e-5);
            Assert.AreEqual(0.84134473, Util.Phi(1), 1e-5);
            Assert.AreEqual(0.97724993, Util.Phi(2), 1e-5);
            Assert.AreEqual(0.99865003, Util.Phi(3), 1e-5);
        }


    }
}