using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using static KursovoySorting.Form1;
using System.Windows.Forms;
using System.Reflection;

namespace KursovoySorting.output
{
    class Init
    {
        public static void InitElements()
        {
            LabelSortname.Visible = false;
            LabelInput.Visible = false;
            LabelInput2.Visible = false;
            TextBoxInput.Visible = false;
            ButtonSort.Visible = false;

            LabelTime.Visible = false;
            RichTextBoxTime.Visible = false;

            RichTextBoxOutput.Visible = false;
            RichTextBoxOutput.ReadOnly = true;
            RichTextBoxOutput.TabStop = false;
            RichTextBoxOutput.Multiline = true;
            RichTextBoxOutput.ScrollBars = RichTextBoxScrollBars.Both;
            RichTextBoxOutput.BackColor = Color.White;
            RichTextBoxOutput.BorderStyle = BorderStyle.Fixed3D;

            ButtonCopy.Visible = false;
        }

        public static void InitMenu()
        {
            RichTextBoxTime.Visible = false;
            LabelIntro.Visible = false;
            LabelSortname.Visible = true;
            LabelInput.Visible = true;
            LabelInput2.Visible = true;
            LabelTime.Visible = false;
            TextBoxInput.Visible = true;
            ButtonSort.Visible = true;
            ButtonCopy.Visible = false;
        }

        public static void InitVariables()
        {
            //Form1 form = new Form1();
            //RichTextBoxOutput = form.Controls["rtb_output"] as RichTextBox;
            //RichTextBoxOutput = RichTextBoxOutput.GetType().GetProperty("Name").GetValue(RichTextBoxOutput) as RichTextBox;


            /*            richTbOutput = rtb_output;
                        richTbTime = rtb_time;
                        copyButton = btn_copy;
                        labelTime = lb_time;
                        _notifyIcon = notifyIcon;
                        _textboxInput = tb_input;*/
        }
    }
}
