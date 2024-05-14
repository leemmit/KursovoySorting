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
            // Вызов рекурсивной функции сортировки
            MergeSortRecursive(arr, 0, arr.Length - 1);
        }

        // Рекурсивная функция для деления массива
        private static void MergeSortRecursive(double[] arr, int l, int r)
        {
            // Базовый случай рекурсии
            if (l < r)
            {
                // Нахождение середины массива
                int m = l + (r - l) / 2;

                // Рекурсивное деление левой половины
                MergeSortRecursive(arr, l, m);
                // Рекурсивное деление правой половины
                MergeSortRecursive(arr, m + 1, r);

                // Слияние отсортированных половин
                Merge(arr, l, m, r);
            }
        }

        // Функция для слияния двух подмассивов
        private static void Merge(double[] arr, int l, int m, int r)
        {
            // Вычисление размеров временных массивов
            int n1 = m - l + 1;
            int n2 = r - m;

            // Создание временных массивов
            double[] L = new double[n1];
            double[] R = new double[n2];

            // Копирование данных во временные массивы
            Array.Copy(arr, l, L, 0, n1);
            Array.Copy(arr, m + 1, R, 0, n2);

            // Индексы для обхода временных массивов и основного массива
            int i = 0, j = 0;
            int k = l;

            // Слияние временных массивов обратно в основной массив
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

            // Копирование оставшихся элементов из L, если они есть
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Копирование оставшихся элементов из R, если они есть
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }

}
