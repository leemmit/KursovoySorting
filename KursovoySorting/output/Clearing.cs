using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoySorting.output
{
    class Clearing
    {
        public static void clearOutput()
        {
            Form1.RichTextBoxOutput.Clear();
            Form1.RichTextBoxOutput.Visible = false;
            Form1.TextBoxInput.Clear();
            Form1.RichTextBoxTime.Clear();
        }
    }
}
