using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoySorting.Sorting
{
    class HeapSort
    {
        // Публичный метод для начала сортировки
        public static void Sort(double[] arr)
        {
            int n = arr.Length;

            // Построение кучи (перестройка массива)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Один за другим извлекаем элементы из кучи
            for (int i = n - 1; i > 0; i--)
            {
                // Перемещение текущего корня в конец
                double temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // вызов процедуры heapify на уменьшенной куче
                Heapify(arr, i, 0);
            }
        }

        // Процедура для преобразования поддерева в двоичную кучу
        private static void Heapify(double[] arr, int n, int i)
        {
            int largest = i; // Инициализация наибольшего элемента как корня
            int l = 2 * i + 1; // левый = 2*i + 1
            int r = 2 * i + 2; // правый = 2*i + 2

            // Если левый дочерний элемент больше корня
            if (l < n && arr[l] > arr[largest])
            {
                largest = l;
            }

            // Если правый дочерний элемент больше, чем наибольший на данный момент
            if (r < n && arr[r] > arr[largest])
            {
                largest = r;
            }

            // Если наибольший элемент не корень
            if (largest != i)
            {
                double swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Рекурсивно преобразуем затронутое поддерево
                Heapify(arr, n, largest);
            }
        }
    }
}
