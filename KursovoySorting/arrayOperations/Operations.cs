using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KursovoySorting.Sorting;
using KursovoySorting;
using KursovoySorting.output;

namespace KursovoySorting.arrayOperations
{
    class Operations
    {
        public static double[] arrayStrToDouble(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++) { strArr[i] = strArr[i].Replace('.', ','); }
            double[] inputDoubled = Array.ConvertAll(strArr, s =>
            {
                if (double.TryParse(s, out double number))
                {
                    return number;
                }
                else
                {
                    Notification.notify("Значения введены некорректно", "Пожалуйста, проверьте правильность ввода и попробуйте еще раз");

                    Form1.IfNotify = true;
                    return 0;
                }
            });
            return inputDoubled;
        }

        public static void chooseSort(double[] inputDoubled)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            switch (Form1.WhichSort)
            {
                case "Сортировка выбором":
                    SelectionSort.Sort(inputDoubled);
                    break;
                case "Сортировка вставками":
                    InsertionSort.Sort(inputDoubled);
                    break;
                case "Сортировка слиянием":
                    MergeSort.Sort(inputDoubled);
                    break;
                case "Сортировка\nпирамидальным деревом":
                    HeapSort.Sort(inputDoubled);
                    break;
                default:
                    break;
            }
            stopwatch.Stop();
            Form1.RichTextBoxTime.AppendText(stopwatch.ElapsedTicks.ToString() + " тиков");

        }

        public static void printSort(double[] inputDoubled)
        {
            if (!Form1.IfNotify)
            {
                Form1.RichTextBoxOutput.Visible = true;
                Form1.RichTextBoxOutput.Clear();
                Form1.ButtonCopy.Visible = true;
                Form1.RichTextBoxTime.Clear();
                Form1.RichTextBoxTime.Visible = true;
                Form1.LabelTime.Visible = true;

                chooseSort(inputDoubled);

                //for (int i = 0; i < inputArr.Length; i++) { inputArr[i] = inputArr[i].Replace('.', ','); }

                for (int i = 0; i < inputDoubled.Length - 1; i++)
                {
                    Form1.RichTextBoxOutput.AppendText(inputDoubled[i].ToString().Replace(',', '.') + ", ");
                }
                Form1.RichTextBoxOutput.AppendText(inputDoubled[inputDoubled.Length - 1].ToString().Replace(',', '.'));
            }
        }
    }
}
