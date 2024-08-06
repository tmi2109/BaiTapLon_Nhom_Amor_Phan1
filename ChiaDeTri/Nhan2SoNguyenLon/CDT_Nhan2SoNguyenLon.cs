using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Nhan2SoNguyenLon
{
    class CDT_Nhan2SoNguyenLon
    {
        static void Main()
        {
            BigInteger num1, num2;

            Console.Write("Nhap so nguyen lon thu nhat: ");
            string input1 = Console.ReadLine();
            BigInteger.TryParse(input1, out num1);

            Console.Write("Nhap so nguyen lon thu hai: ");
            string input2 = Console.ReadLine();
            BigInteger.TryParse(input2, out num2);

            BigInteger result = BigNumberMultiply(num1, num2);

            Console.WriteLine("Ket qua: " + result);
            Console.ReadKey();
        }

        static BigInteger BigNumberMultiply(BigInteger X, BigInteger Y)
        {
            int n = Math.Max(X.ToString().Length, Y.ToString().Length);

            return BigNumberMultiplyHelper(X, Y, n);
        }

        static BigInteger BigNumberMultiplyHelper(BigInteger X, BigInteger Y, int n)
        {
            if (n == 1)
                return X * Y;

            int m = n / 2;

            BigInteger A = X / BigInteger.Pow(10, m);
            BigInteger B = X % BigInteger.Pow(10, m);
            BigInteger C = Y / BigInteger.Pow(10, m);
            BigInteger D = Y % BigInteger.Pow(10, m);

            BigInteger m1 = BigNumberMultiplyHelper(A, C, m);
            BigInteger m2 = BigNumberMultiplyHelper(A - B, D - C, m);
            BigInteger m3 = BigNumberMultiplyHelper(B, D, m);

            return m1 * BigInteger.Pow(10, 2 * m) + (m1 + m2 + m3) * BigInteger.Pow(10, m) + m3;
        }
    }
}
