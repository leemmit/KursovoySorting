using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KursovoySorting.Sorting;

namespace KursovoySorting
{
    public partial class Form1 : Form
    {
        private string whichSort = "";

        private void ClearOutput()
        {

            rtb_output.Clear();
            rtb_output.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            lb_sortname.Visible = false;
            lb_input.Visible = false;
            tb_input.Visible = false;
            btn_sort.Visible = false;

            rtb_output.Visible = false;
            rtb_output.ReadOnly = true;
            rtb_output.TabStop = false;
            rtb_output.Multiline = true;
            rtb_output.ScrollBars = RichTextBoxScrollBars.Both;
            rtb_output.BackColor = Color.White;
            rtb_output.BorderStyle = BorderStyle.Fixed3D;

            
        }

        private void menu_select_Click(object sender, EventArgs e)
        {
            ClearOutput();
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            lb_intro.Visible = false;
            lb_sortname.Visible = true;
            lb_input.Visible = true;
            tb_input.Visible = true;
            btn_sort.Visible = true;

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
            rtb_output.Visible = true;

            char[] delimiters = new char[] { ',', ' ' };
            string inputString = tb_input.Text;
            string[] inputArr = inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputArr.Length; i++) { inputArr[i] = inputArr[i].Replace('.', ','); }

            //for (int i = 0; i < inputArr.Length - 1; i++) { inputDoubled[i] = Double.Parse(inputArr[i]); }
            //foreach (string item in inputArr) { inputDoubled.Append(Double.Parse(item)); }
            double[] inputDoubled = Array.ConvertAll(inputArr, s => double.Parse(s));
            for (int i = 0; i < inputArr.Length; i++) { inputArr[i] = inputArr[i].Replace('.', ','); }

            switch (whichSort)
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

            for (int i = 0; i < inputDoubled.Length-1; i++)
            {
                rtb_output.AppendText(inputDoubled[i].ToString().Replace(',', '.') + ", ");
            }
            rtb_output.AppendText(inputDoubled[inputDoubled.Length-1].ToString().Replace(',', '.'));
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_output.Text);
        }
    }
}
