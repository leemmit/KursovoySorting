using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoySorting.Sorting
{
    class SelectionSort
    {
        public static void Sort(double[] arr)
        {
            int n = arr.Length; // Получаем длину массива

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i; // Предполагаем, что текущий элемент - минимальный

                for (int j = i + 1; j < n; j++)     // Ищем наименьший элемент в оставшейся части массива
                {
                    // Если находим элемент меньше, обновляем индекс минимального элемента
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                
                double temp = arr[minIndex]; // Меняем местами найденный минимальный элемент с первым неотсортированным
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
