using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimKiemNhiPhan
{
    class CDT_TimKiemNhiPhan
    {
        const int MAX = 1000;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;
            do
            {
                Console.Write("Nhap phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0 || n > MAX);

            NhapMang(a, ref n);
            XuatMang(a, n);

            Console.Write("\nNhap x can tim: ");
            int x = int.Parse(Console.ReadLine());

            int kq = BinarySearch(a, 0, n - 1, x);
            if (kq == -1)
                Console.WriteLine($"Khong tim thay {x} trong mang");
            else
                Console.WriteLine($"Tim thay {x} tai vi tri thu {kq}");
            Console.ReadLine();
        }

        static void NhapMang(int[] a, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static int BinarySearch(int[] a, int left, int right, int x)
        {
            if (left > right)
                return -1;
            int mid = (left + right) / 2;
            if (a[mid] == x)
                return mid;
            if (a[mid] > x)
                return BinarySearch(a, left, mid - 1, x);
            else
                return BinarySearch(a, mid + 1, right, x);
        }
    }
}
