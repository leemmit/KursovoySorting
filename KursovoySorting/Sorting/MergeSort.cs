using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoySorting.Sorting
{
    class MergeSort
    {
        public static void Sort(double[] arr)
        {
            MergeSortRecursive(arr, 0, arr.Length - 1);
        }

        private static void MergeSortRecursive(double[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                MergeSortRecursive(arr, l, m);
                MergeSortRecursive(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }

        private static void Merge(double[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            double[] L = new double[n1];
            double[] R = new double[n2];

            Array.Copy(arr, l, L, 0, n1);
            Array.Copy(arr, m + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
