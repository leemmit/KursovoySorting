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
            tb_input.Clear();
            rtb_time.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            lb_sortname.Visible = false;
            lb_input.Visible = false;
            lb_input2.Visible = false;
            tb_input.Visible = false;
            btn_sort.Visible = false;

            lb_time.Visible = false;
            rtb_time.Visible = false;

            rtb_output.Visible = false;
            rtb_output.ReadOnly = true;
            rtb_output.TabStop = false;
            rtb_output.Multiline = true;
            rtb_output.ScrollBars = RichTextBoxScrollBars.Both;
            rtb_output.BackColor = Color.White;
            rtb_output.BorderStyle = BorderStyle.Fixed3D;

            btn_copy.Visible = false;
        }

        private void menu_select_Click(object sender, EventArgs e)
        {
            ClearOutput();
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            lb_intro.Visible = false;
            lb_sortname.Visible = true;
            lb_input.Visible = true;
            lb_input2.Visible = true;
            tb_input.Visible = true;
            btn_sort.Visible = true;
            btn_copy.Visible = false;

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
            char[] delimiters = new char[] { ',', ' ' };
            string inputString = tb_input.Text;
            string[] inputArr = inputString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (inputArr.Length == 0)
            {
                notifyIcon.BalloonTipTitle = "Значения введены некорректно";
                notifyIcon.BalloonTipText = "Пожалуйста, проверьте правильность ввода и попробуйте еще раз";
                notifyIcon.ShowBalloonTip(2000);
            }
            else
            {
                bool ifNotify = false;

                for (int i = 0; i < inputArr.Length; i++) { inputArr[i] = inputArr[i].Replace('.', ','); }
                double[] inputDoubled = Array.ConvertAll(inputArr, s =>
                {
                    if (double.TryParse(s, out double number))
                    {
                        return number;
                    }
                    else
                    {
                        notifyIcon.BalloonTipTitle = "Значения введены некорректно";
                        notifyIcon.BalloonTipText = "Пожалуйста, проверьте правильность ввода и попробуйте еще раз";
                        notifyIcon.ShowBalloonTip(2000);
                        ifNotify = true;
                        return 0;
                    }
                });

                if (!ifNotify)
                {
                    rtb_output.Visible = true;
                    btn_copy.Visible = true;
                    rtb_output.Clear();
                    rtb_time.Clear();
                    lb_time.Visible = true;
                    rtb_time.Visible = true;

                    System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

                    for (int i = 0; i < inputArr.Length; i++) { inputArr[i] = inputArr[i].Replace('.', ','); }

                    stopwatch.Start();
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
                    stopwatch.Stop();

                    rtb_time.AppendText(stopwatch.ElapsedTicks.ToString() + " тиков");

                    for (int i = 0; i < inputDoubled.Length - 1; i++)
                    {
                        rtb_output.AppendText(inputDoubled[i].ToString().Replace(',', '.') + ", ");
                    }
                    rtb_output.AppendText(inputDoubled[inputDoubled.Length - 1].ToString().Replace(',', '.'));
                }
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb_output.Text);

            notifyIcon.BalloonTipTitle = "Уведомление";
            notifyIcon.BalloonTipText = "Текст успешно скопирован!";
            notifyIcon.ShowBalloonTip(3000);
        }

        private void tb_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_sort_Click(sender, e);
            }
        }
    }
}
