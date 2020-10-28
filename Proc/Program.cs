using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcLib.Proc P = new ProcLib.Proc();
            double[] TestArray = new double[] { 0, 1, 3, 8, 10.1 };
            double[] MachineTestAnswers = new double[] { 0, 1, 3, 8, 10.1 };
            double[] TrueTestAnswers = new double[] { 0, 1, 27, 512, 1030.301 };
            for (int i = 0; i < 5; i++)
            {
                P.PowerA3(TestArray[i], out MachineTestAnswers[i]);
                Console.WriteLine(MachineTestAnswers[i]);
            }
            double X;
            double Y;
            double A = 5;
            double B = 8;
            P.Mean(A, B, out X, out Y);
            Console.WriteLine(X);
            Console.WriteLine(Y);
            double a1 = 2;
            double a2 = 3;
            double a3 = 15.123;
            double h1 = 12;
            double h2 = 13;
            double h3 = 14;
            Console.WriteLine(P.TriangleP(a1, h1));
            Console.WriteLine(P.TriangleP(a2, h2));
            Console.WriteLine(P.TriangleP(a3, h3));
            Console.ReadKey();
        }
    }
}
