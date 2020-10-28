using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcLibUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Proc1()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double[] TestArray = new double[] {0, 1, 3, 8, 10.1};
            double[] MachineTestAnswers = new double[] {0, 1, 3, 8, 10.1 };
            double[] TrueTestAnswers = new double[] {0, 1, 27, 512, 1030.301};
            for (int i = 0; i < 5; i++)
            {
                P.PowerA3(TestArray[i], out MachineTestAnswers[i]);
                Assert.AreEqual(MachineTestAnswers[i], TrueTestAnswers[i], 0, "ashibka Proc1");
            }
        }
        [TestMethod]
        public void Proc3()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double A = 5;
            double B = 8;
            double C = 7;
            double D = 56;
            double X;
            double Y;
            P.Mean(A, B, out X, out Y);
            Assert.AreEqual(X, 6.5, 0.001, "first PoS X");
            Assert.AreEqual(Y, 6.324, 0.001, "first PoS Y");
            P.Mean(A, C, out X, out Y);
            Assert.AreEqual(X, 6, 0.001, "second PoS X");
            Assert.AreEqual(Y, 5.916, 0.001, "second PoS Y");
            P.Mean(A, D, out X, out Y);
            Assert.AreEqual(X, 30.5, 0.001, "third PoS X");
            Assert.AreEqual(Y, 16.733, 0.001, "third PoS Y");
        }
        [TestMethod]
        public void Proc5()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double[] F = new double[] {-1, -2, 8, 9};
            double[] S = new double[] {4, 6, 7, 13};
            double[] T = new double[] {0, 0, 2.5, 2.5};
            double TriangleP = 0;
            double TriangleS = 0;
            P.RectPS(F[0], F[1], F[2], F[3], out TriangleP, out TriangleS);
            Assert.AreEqual(TriangleP, 40, "f p");
            Assert.AreEqual(TriangleS, 99, "f s");
            P.RectPS(S[0], S[1], S[2], S[3], out TriangleP, out TriangleS);
            Assert.AreEqual(TriangleP, 20, "s p");
            Assert.AreEqual(TriangleS, 21, "s s");
            P.RectPS(T[0], T[1], T[2], T[3], out TriangleP, out TriangleS);
            Assert.AreEqual(TriangleP, 10, "t p");
            Assert.AreEqual(TriangleS, 6.25, "t s");
        }
        [TestMethod]
        public void Proc7()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            int[] TestArray = new int[] { 0, 123, 333, 824, 123654 };
            double[] MachineTestAnswers = new double[] { 0, 1, 3, 8, 10.1 };
            double[] TrueTestAnswers = new double[] { 0, 321, 333, 428, 456321 };
            for (int i = 0; i < 5; i++)
            {
                P.PowerA3(TestArray[i], out MachineTestAnswers[i]);
                Assert.AreEqual(MachineTestAnswers[i], TrueTestAnswers[i], "ashibka Proc7");
            }
        }
        [TestMethod]
        public void Proc16()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double A = 12.123;
            double B = -15.321;
            Assert.AreEqual(P.Sign(A) + P.Sign(B), 0, "ashibka Proc16");
        }
        [TestMethod]
        public void Proc18()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double[] X = new double[] { 1, 12.123, 41132 };
            for (int i = 0; i < 3; i++)
            {
                X[i] = P.CircleS(X[i]);
            }
            Assert.AreEqual(X[0], 3.14, "really dumb error");
            Assert.AreEqual(X[1], 461.476, 0.001, "okaaaaay");
            Assert.AreEqual(X[2], 5312382071.36, 1, "probably not enough memory");
        }
        [TestMethod]
        public void Proc20()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double a1 = 2;
            double a2 = 3;
            double a3 = 15.123;
            double h1 = 12;
            double h2 = 13;
            double h3 = 14;
            Assert.AreEqual(P.TriangleP(a1, h1), 26, 1);
            Assert.AreEqual(P.TriangleP(a2, h2), 29, 1);
            Assert.AreEqual(P.TriangleP(a3, h3), 46, 1);
        }
        [TestMethod]
        public void Proc37()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double p = 4;
            double a = 2;
            double b = 3.14;
            double c = 10;
            Assert.AreEqual(P.Power1(a, p), 16, 1);
            Assert.AreEqual(P.Power1(b, p), 97.2117122, 0.0001);
            Assert.AreEqual(P.Power1(c, p), 10000, 1);
        }
        [TestMethod]
        public void Proc83()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double a = 5.5;
            int c = 0;
            int l = 2;
            int m = -4;
            Assert.AreEqual(P.Power2(a, c), 1);
            Assert.AreEqual(P.Power2(a, l), 30.25);
            Assert.AreEqual(P.Power2(a, m), 0.00109282153, 0.000000001);
        }
        [TestMethod]
        public void Proc84()
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double p = 4;
            double a = 2;
            double b = 3.14;
            double c = 10;
            Assert.AreEqual(P.Power1(a, p), 16, 1);
            Assert.AreEqual(P.Power1(b, p), 97.2117122, 0.0001);
            Assert.AreEqual(P.Power1(c, p), 10000, 1);
        }
    }
}
