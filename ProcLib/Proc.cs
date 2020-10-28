using System;

namespace ProcLib
{
    public class Proc
    {
        public void PowerA3(double A, out double B)
        {
            B = Math.Pow(A, 3);
        }
        public void Mean(double X, double Y, out double AMean, out double GMean)
        {
            AMean = (X + Y) / 2;
            GMean = Math.Sqrt(X * Y);
        }
        public void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            P = (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2;
            S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
        }
        public void InvertDigits(ref int K)
        {
            int A = K;
            char[] S = A.ToString().ToCharArray();
            char[] Ans = S;
            int len = S.Length;
            for (int i = 0; i< len; i++)
            {
                Ans[i] = S[len - i];
            }
            K = int.Parse(S.ToString());
        }
        public int Sign(double X)
        {
            return X>0?1:X==0?0:-1;
        }
        public double CircleS(double R)
        {
            return 3.14 * R * R;
        }
        public double TriangleP(double a, double h)
        {
            return a + 2 * Math.Sqrt(a * a / 4 + h * h);
        }
        public double Power1(double A, double B)
        {
            double X = Math.Exp(B * Math.Log(A));
            return X > 0 ? X : 0;
        }
        public double Power2(double A, int N)
        {
            return A == 0 ? 0 : A > 0 ? Math.Pow(A, N) : 1 / Math.Pow(A, -N);
        }
        public double Power3(double A, double B)
        {
            return B % 0 == 0 ? Power2(A, Convert.ToInt32(Math.Round(B))) : Power1(A, B);
        }
    }
}
