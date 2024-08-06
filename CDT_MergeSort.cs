using System;

namespace MergeSort
{
    class CDT_MergeSort
    {
        const int MAX = 100;

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0 || n > MAX);

            NhapMang(a, n);
            Console.WriteLine("\nMang chua duoc sap xep: ");
            XuatMang(a, n);

            MergeSort(a, 0, n - 1);

            Console.WriteLine("\nMang sau khi duoc sap xep: ");
            XuatMang(a, n);
            Console.ReadLine();
        }

        static void NhapMang(int[] a, int n)
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

        static void Merge(int[] a, int l, int mid, int r)
        {
            int n1 = mid - l + 1;
            int n2 = r - mid;

            int[] left = new int[n1];
            int[] right = new int[n2];

            Array.Copy(a, l, left, 0, n1);
            Array.Copy(a, mid + 1, right, 0, n2);

            int i = 0, j = 0, k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                    a[k++] = left[i++];
                else
                    a[k++] = right[j++];
            }

            while (i < n1)
                a[k++] = left[i++];

            while (j < n2)
                a[k++] = right[j++];
        }

        static void MergeSort(int[] a, int l, int r)
        {

            if (l < r)
            {
                int mid = l + (r - l) / 2;

                MergeSort(a, l, mid);
                MergeSort(a, mid + 1, r);

                Merge(a, l, mid, r);
            }
        }

    }
}
