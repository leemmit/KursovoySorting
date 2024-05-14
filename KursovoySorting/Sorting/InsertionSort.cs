using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoySorting.Sorting
{
    class InsertionSort
    {
        // Публичный метод для начала сортировки
        public static void Sort(double[] arr)
        {
            // Получение размера массива
            int n = arr.Length;

            // Проход по массиву, начиная со второго элемента
            for (int i = 1; i < n; ++i)
            {
                // Выбор ключевого элемента для сравнения
                double key = arr[i];
                // Начало сравнения с элементом перед ключевым
                int j = i - 1;

                // Сдвиг элементов, которые больше ключевого, вперед
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                // Вставка ключевого элемента на правильное место
                arr[j + 1] = key;
            }
        }
    }
}
