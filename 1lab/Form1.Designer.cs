namespace _1lab
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopPlaySimulationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allForceTextBox = new System.Windows.Forms.TextBox();
            this.currTimeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.massCenterXTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.massCenterYTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.createSystemToolStripMenuItem,
            this.startModelToolStripMenuItem,
            this.stopPlaySimulationButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // createSystemToolStripMenuItem
            // 
            this.createSystemToolStripMenuItem.Name = "createSystemToolStripMenuItem";
            this.createSystemToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.createSystemToolStripMenuItem.Text = "Создать систему";
            this.createSystemToolStripMenuItem.Click += new System.EventHandler(this.createSystemToolStripMenuItem_Click);
            // 
            // startModelToolStripMenuItem
            // 
            this.startModelToolStripMenuItem.Name = "startModelToolStripMenuItem";
            this.startModelToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.startModelToolStripMenuItem.Text = "Запуск Модели";
            this.startModelToolStripMenuItem.Click += new System.EventHandler(this.startModelToolStripMenuItem_Click);
            // 
            // stopPlaySimulationButton
            // 
            this.stopPlaySimulationButton.Name = "stopPlaySimulationButton";
            this.stopPlaySimulationButton.Size = new System.Drawing.Size(29, 20);
            this.stopPlaySimulationButton.Text = "■";
            this.stopPlaySimulationButton.Click += new System.EventHandler(this.stopPlaySimulationButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая Энергия (Дж)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оставшееся время\r\nсимуляции (с)\r\n";
            // 
            // allForceTextBox
            // 
            this.allForceTextBox.Location = new System.Drawing.Point(12, 87);
            this.allForceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allForceTextBox.Name = "allForceTextBox";
            this.allForceTextBox.ReadOnly = true;
            this.allForceTextBox.Size = new System.Drawing.Size(137, 20);
            this.allForceTextBox.TabIndex = 3;
            this.allForceTextBox.Text = "0";
            // 
            // currTimeTextBox
            // 
            this.currTimeTextBox.Location = new System.Drawing.Point(12, 141);
            this.currTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currTimeTextBox.Name = "currTimeTextBox";
            this.currTimeTextBox.ReadOnly = true;
            this.currTimeTextBox.Size = new System.Drawing.Size(137, 20);
            this.currTimeTextBox.TabIndex = 4;
            this.currTimeTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Центр масс Vx";
            // 
            // massCenterXTextBox
            // 
            this.massCenterXTextBox.Location = new System.Drawing.Point(15, 182);
            this.massCenterXTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.massCenterXTextBox.Name = "massCenterXTextBox";
            this.massCenterXTextBox.ReadOnly = true;
            this.massCenterXTextBox.Size = new System.Drawing.Size(134, 20);
            this.massCenterXTextBox.TabIndex = 6;
            this.massCenterXTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Центр масс Vy";
            // 
            // massCenterYTextBox
            // 
            this.massCenterYTextBox.Location = new System.Drawing.Point(15, 223);
            this.massCenterYTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.massCenterYTextBox.Name = "massCenterYTextBox";
            this.massCenterYTextBox.ReadOnly = true;
            this.massCenterYTextBox.Size = new System.Drawing.Size(134, 20);
            this.massCenterYTextBox.TabIndex = 8;
            this.massCenterYTextBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Модель не запущена";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.massCenterYTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.massCenterXTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currTimeTextBox);
            this.Controls.Add(this.allForceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startModelToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem createSystemToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem stopPlaySimulationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox allForceTextBox;
        private System.Windows.Forms.TextBox currTimeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox massCenterXTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox massCenterYTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

