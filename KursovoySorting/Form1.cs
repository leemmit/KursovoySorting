using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KursovoySorting.arrayOperations;
using KursovoySorting.output;
using KursovoySorting.buttons;

namespace KursovoySorting
{
    public partial class Form1 : Form
    {
        private static string whichSort = "";
        public static string WhichSort { get => whichSort; set => whichSort = value; }
        private static bool ifNotify;
        public static bool IfNotify { get => ifNotify; set => ifNotify = value; }


        static RichTextBox richTbOutput;
        static RichTextBox richTbTime;
        static TextBox _textboxInput;
        static Button copyButton;
        static Button sortButton;

        static Label labelTime;
        //static Label labelCopy;
        static Label labelInput;
        static Label labelInput2;
        static Label labelSortname;
        static Label labelIntro;
        static NotifyIcon _notifyIcon;
        public static RichTextBox RichTextBoxOutput { get => richTbOutput; set => richTbOutput = value; }
        public static RichTextBox RichTextBoxTime { get => richTbTime; set => richTbTime = value; }
        public static Button ButtonCopy { get => copyButton; set => copyButton = value; }
        public static Button ButtonSort { get => sortButton; set => sortButton = value; }
        public static Label LabelInput { get => labelInput; set => labelInput = value; }
        public static Label LabelInput2 { get => labelInput2; set => labelInput2 = value; }
        public static Label LabelTime { get => labelTime; set => labelTime = value; }
        public static Label LabelSortname { get => labelSortname; set => labelSortname = value; }
        public static Label LabelIntro { get => labelIntro; set => labelIntro = value; }
        //public static Label LabelCopy { get => labelCopy; set => labelCopy = value; }

        public static NotifyIcon NotifyIcon { get => _notifyIcon; set => _notifyIcon = value; }
        public static TextBox TextBoxInput { get => _textboxInput; set => _textboxInput = value; }




        public Form1()
        {
            InitializeComponent();
            InitVariables();
            Init.InitElements();
        }



        private void menu_select_Click(object sender, EventArgs e)
        {
            Clearing.clearOutput();
            Init.InitMenu();

            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            switch (clickedItem.Name)
            {
                case "selection_sort":
                    lb_sortname.Text = "Сортировка выбором";
                    break;
                case "insertion_sort":
                    lb_sortname.Text = "Сортировка вставками";
                    break;
                case "merge_sort":
                    lb_sortname.Text = "Сортировка слиянием";
                    break;
                case "heap_sort":
                    lb_sortname.Text = "Сортировка\nпирамидальным деревом";
                    break;
            }
            whichSort = lb_sortname.Text;
        }

        private void btn_sort_Click(object sender, EventArgs e) 
        {
            Buttons.btnSortClick();
        }
        private void btn_copy_Click(object sender, EventArgs e)
        {
            Buttons.btnCopyClick();
        }
        private void tb_input_KeyDown(object sender, KeyEventArgs e)
        {
            Buttons.tbInputKeydown(e);
        }

        void InitVariables()
        {
            richTbOutput = rtb_output;
            richTbTime = rtb_time;
            _textboxInput = tb_input;

            copyButton = btn_copy;
            sortButton = btn_sort;

            labelTime = lb_time;
            labelInput = lb_input;
            labelInput2 = lb_input2;
            labelSortname = lb_sortname;
            labelIntro = lb_intro;

            _notifyIcon = notifyIcon;
        }
    }
}
