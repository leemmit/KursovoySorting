
namespace KursovoySorting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftMenu = new System.Windows.Forms.MenuStrip();
            this.selection_sort = new System.Windows.Forms.ToolStripMenuItem();
            this.insertion_sort = new System.Windows.Forms.ToolStripMenuItem();
            this.merge_sort = new System.Windows.Forms.ToolStripMenuItem();
            this.heap_sort = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_intro = new System.Windows.Forms.Label();
            this.lb_sortname = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lb_input2 = new System.Windows.Forms.Label();
            this.rtb_time = new System.Windows.Forms.RichTextBox();
            this.lb_time = new System.Windows.Forms.Label();
            this.leftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMenu
            // 
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.leftMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.leftMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selection_sort,
            this.insertion_sort,
            this.merge_sort,
            this.heap_sort});
            this.leftMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.leftMenu.Location = new System.Drawing.Point(0, 0);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(356, 709);
            this.leftMenu.TabIndex = 0;
            this.leftMenu.Text = "menuStrip1";
            // 
            // selection_sort
            // 
            this.selection_sort.Name = "selection_sort";
            this.selection_sort.Size = new System.Drawing.Size(212, 29);
            this.selection_sort.Tag = "1";
            this.selection_sort.Text = "Сортировка выбором";
            this.selection_sort.Click += new System.EventHandler(this.menu_select_Click);
            // 
            // insertion_sort
            // 
            this.insertion_sort.Name = "insertion_sort";
            this.insertion_sort.Size = new System.Drawing.Size(218, 29);
            this.insertion_sort.Tag = "2";
            this.insertion_sort.Text = "Сортировка вставками";
            this.insertion_sort.Click += new System.EventHandler(this.menu_select_Click);
            // 
            // merge_sort
            // 
            this.merge_sort.Name = "merge_sort";
            this.merge_sort.Size = new System.Drawing.Size(211, 29);
            this.merge_sort.Tag = "3";
            this.merge_sort.Text = "Сортировка слиянием";
            this.merge_sort.Click += new System.EventHandler(this.menu_select_Click);
            // 
            // heap_sort
            // 
            this.heap_sort.Name = "heap_sort";
            this.heap_sort.Size = new System.Drawing.Size(347, 29);
            this.heap_sort.Tag = "4";
            this.heap_sort.Text = "Сортировка пирамидальным деревом";
            this.heap_sort.Click += new System.EventHandler(this.menu_select_Click);
            // 
            // lb_intro
            // 
            this.lb_intro.AutoSize = true;
            this.lb_intro.Font = new System.Drawing.Font("Sans Serif Collection", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_intro.Location = new System.Drawing.Point(393, 272);
            this.lb_intro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_intro.Name = "lb_intro";
            this.lb_intro.Size = new System.Drawing.Size(660, 98);
            this.lb_intro.TabIndex = 3;
            this.lb_intro.Text = "Программа сортировки\r\nВыберите способ сортировки на панели слева\r\n";
            this.lb_intro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sortname
            // 
            this.lb_sortname.AutoSize = true;
            this.lb_sortname.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sortname.Location = new System.Drawing.Point(387, 9);
            this.lb_sortname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sortname.Name = "lb_sortname";
            this.lb_sortname.Size = new System.Drawing.Size(375, 59);
            this.lb_sortname.TabIndex = 4;
            this.lb_sortname.Text = "Метод сортировки";
            this.lb_sortname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_input.Location = new System.Drawing.Point(392, 138);
            this.lb_input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(419, 39);
            this.lb_input.TabIndex = 5;
            this.lb_input.Text = "Введите массив для сортировки:";
            this.lb_input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("Sans Serif Collection", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_input.Location = new System.Drawing.Point(399, 208);
            this.tb_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(654, 55);
            this.tb_input.TabIndex = 6;
            this.tb_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_input_KeyDown);
            // 
            // btn_sort
            // 
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sort.Location = new System.Drawing.Point(870, 279);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(183, 53);
            this.btn_sort.TabIndex = 8;
            this.btn_sort.Text = "Cортировать";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_output.Location = new System.Drawing.Point(399, 394);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(654, 127);
            this.rtb_output.TabIndex = 9;
            this.rtb_output.Text = "";
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_copy.Image = global::KursovoySorting.Properties.Resources.icons8_copy_24;
            this.btn_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy.Location = new System.Drawing.Point(853, 527);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(200, 53);
            this.btn_copy.TabIndex = 10;
            this.btn_copy.Text = "    Копировать";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "Текст скопирован";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Текст скопирован";
            this.notifyIcon.Visible = true;
            // 
            // lb_input2
            // 
            this.lb_input2.AutoSize = true;
            this.lb_input2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_input2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_input2.Location = new System.Drawing.Point(397, 174);
            this.lb_input2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_input2.Name = "lb_input2";
            this.lb_input2.Size = new System.Drawing.Size(519, 29);
            this.lb_input2.TabIndex = 11;
            this.lb_input2.Text = "(Можно использовать разделители \" \" и/или \",\")";
            this.lb_input2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtb_time
            // 
            this.rtb_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_time.Location = new System.Drawing.Point(635, 541);
            this.rtb_time.Name = "rtb_time";
            this.rtb_time.Size = new System.Drawing.Size(148, 39);
            this.rtb_time.TabIndex = 12;
            this.rtb_time.Text = "";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.lb_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_time.Location = new System.Drawing.Point(395, 541);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(211, 29);
            this.lb_time.TabIndex = 13;
            this.lb_time.Text = "Время сортировки:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 709);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.rtb_time);
            this.Controls.Add(this.lb_input2);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.lb_sortname);
            this.Controls.Add(this.lb_intro);
            this.Controls.Add(this.leftMenu);
            this.MainMenuStrip = this.leftMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.leftMenu.ResumeLayout(false);
            this.leftMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip leftMenu;
        private System.Windows.Forms.ToolStripMenuItem selection_sort;
        private System.Windows.Forms.ToolStripMenuItem insertion_sort;
        private System.Windows.Forms.ToolStripMenuItem merge_sort;
        private System.Windows.Forms.ToolStripMenuItem heap_sort;
        private System.Windows.Forms.Label lb_intro;
        private System.Windows.Forms.Label lb_sortname;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lb_input2;
        private System.Windows.Forms.RichTextBox rtb_time;
        private System.Windows.Forms.Label lb_time;
    }
}

