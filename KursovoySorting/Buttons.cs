using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursovoySorting.arrayOperations;
using KursovoySorting.output;
using System.Windows.Forms;

namespace KursovoySorting.buttons
{
    class Buttons
    {
        public static void btnSortClick()
        {
            // Считывание массива
            char[] delimiters = new char[] { ',', ' ' };
            string inputString = Form1.TextBoxInput.Text;
            string[] inputArr = inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (inputArr.Length != 0)
            {
                Operations.printSort(Operations.arrayStrToDouble(inputArr));
            }
            else
            {
                Notification.notify("Значения введены некорректно", "Пожалуйста, проверьте правильность ввода и попробуйте еще раз");
            }
        }

        public static void btnCopyClick()
        {
            Clipboard.SetText(Form1.RichTextBoxOutput.Text);
            Notification.notify("Уведомление", "Текст успешно скопирован!");
        }

        public static void tbInputKeydown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buttons.btnSortClick();
            }
        }
    }
}
