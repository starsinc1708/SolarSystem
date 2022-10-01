namespace _1lab
{
    partial class ParamsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.systemDataGridView = new System.Windows.Forms.DataGridView();
            this.systemSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planexXColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planexYColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetSpeedXColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetSpeedYColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planetMass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptParamsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simulationStepTimeBox = new System.Windows.Forms.TextBox();
            this.modelingTimeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.planetCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.createSystemButton = new System.Windows.Forms.Button();
            this.EulerMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.CramerEulerMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.VerletMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.BeemanMethodRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.systemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // systemDataGridView
            // 
            this.systemDataGridView.AllowUserToAddRows = false;
            this.systemDataGridView.AllowUserToDeleteRows = false;
            this.systemDataGridView.AllowUserToResizeColumns = false;
            this.systemDataGridView.AllowUserToResizeRows = false;
            this.systemDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.systemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.systemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemSizeColumn,
            this.planexXColumn,
            this.planexYColumn,
            this.planetSpeedXColumn,
            this.planetSpeedYColumn,
            this.planetMass});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.systemDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.systemDataGridView.Location = new System.Drawing.Point(12, 120);
            this.systemDataGridView.Name = "systemDataGridView";
            this.systemDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.systemDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.systemDataGridView.Size = new System.Drawing.Size(776, 318);
            this.systemDataGridView.TabIndex = 0;
            // 
            // systemSizeColumn
            // 
            this.systemSizeColumn.HeaderText = "Column1";
            this.systemSizeColumn.MinimumWidth = 6;
            this.systemSizeColumn.Name = "systemSizeColumn";
            this.systemSizeColumn.ReadOnly = true;
            this.systemSizeColumn.Width = 125;
            // 
            // planexXColumn
            // 
            this.planexXColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planexXColumn.HeaderText = "X";
            this.planexXColumn.MinimumWidth = 6;
            this.planexXColumn.Name = "planexXColumn";
            // 
            // planexYColumn
            // 
            this.planexYColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planexYColumn.HeaderText = "Y";
            this.planexYColumn.MinimumWidth = 6;
            this.planexYColumn.Name = "planexYColumn";
            // 
            // planetSpeedXColumn
            // 
            this.planetSpeedXColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planetSpeedXColumn.HeaderText = "Vx";
            this.planetSpeedXColumn.MinimumWidth = 6;
            this.planetSpeedXColumn.Name = "planetSpeedXColumn";
            // 
            // planetSpeedYColumn
            // 
            this.planetSpeedYColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planetSpeedYColumn.HeaderText = "Vy";
            this.planetSpeedYColumn.MinimumWidth = 6;
            this.planetSpeedYColumn.Name = "planetSpeedYColumn";
            // 
            // planetMass
            // 
            this.planetMass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planetMass.HeaderText = "Масса";
            this.planetMass.MinimumWidth = 6;
            this.planetMass.Name = "planetMass";
            // 
            // acceptParamsButton
            // 
            this.acceptParamsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptParamsButton.Location = new System.Drawing.Point(707, 81);
            this.acceptParamsButton.Name = "acceptParamsButton";
            this.acceptParamsButton.Size = new System.Drawing.Size(81, 33);
            this.acceptParamsButton.TabIndex = 1;
            this.acceptParamsButton.Text = "Ввести";
            this.acceptParamsButton.UseVisualStyleBackColor = true;
            this.acceptParamsButton.Click += new System.EventHandler(this.acceptParamsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шаг по времени";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время моделирования";
            // 
            // simulationStepTimeBox
            // 
            this.simulationStepTimeBox.Location = new System.Drawing.Point(142, 13);
            this.simulationStepTimeBox.Name = "simulationStepTimeBox";
            this.simulationStepTimeBox.Size = new System.Drawing.Size(100, 20);
            this.simulationStepTimeBox.TabIndex = 4;
            this.simulationStepTimeBox.Text = "360000";
            // 
            // modelingTimeBox
            // 
            this.modelingTimeBox.Location = new System.Drawing.Point(142, 37);
            this.modelingTimeBox.Name = "modelingTimeBox";
            this.modelingTimeBox.Size = new System.Drawing.Size(100, 20);
            this.modelingTimeBox.TabIndex = 5;
            this.modelingTimeBox.Text = "31536000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "с";
            // 
            // planetCountNumericUpDown
            // 
            this.planetCountNumericUpDown.Location = new System.Drawing.Point(142, 68);
            this.planetCountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.planetCountNumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.planetCountNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.planetCountNumericUpDown.Name = "planetCountNumericUpDown";
            this.planetCountNumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.planetCountNumericUpDown.TabIndex = 8;
            this.planetCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество планет";
            // 
            // createSystemButton
            // 
            this.createSystemButton.Location = new System.Drawing.Point(142, 91);
            this.createSystemButton.Margin = new System.Windows.Forms.Padding(2);
            this.createSystemButton.Name = "createSystemButton";
            this.createSystemButton.Size = new System.Drawing.Size(99, 24);
            this.createSystemButton.TabIndex = 10;
            this.createSystemButton.Text = "Создать";
            this.createSystemButton.UseVisualStyleBackColor = true;
            this.createSystemButton.Click += new System.EventHandler(this.createSystemButton_Click);
            // 
            // EulerMethodRadioButton
            // 
            this.EulerMethodRadioButton.AutoSize = true;
            this.EulerMethodRadioButton.Checked = true;
            this.EulerMethodRadioButton.Location = new System.Drawing.Point(281, 15);
            this.EulerMethodRadioButton.Name = "EulerMethodRadioButton";
            this.EulerMethodRadioButton.Size = new System.Drawing.Size(96, 17);
            this.EulerMethodRadioButton.TabIndex = 11;
            this.EulerMethodRadioButton.TabStop = true;
            this.EulerMethodRadioButton.Text = "метод Эйлера";
            this.EulerMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // CramerEulerMethodRadioButton
            // 
            this.CramerEulerMethodRadioButton.AutoSize = true;
            this.CramerEulerMethodRadioButton.Location = new System.Drawing.Point(383, 16);
            this.CramerEulerMethodRadioButton.Name = "CramerEulerMethodRadioButton";
            this.CramerEulerMethodRadioButton.Size = new System.Drawing.Size(144, 17);
            this.CramerEulerMethodRadioButton.TabIndex = 12;
            this.CramerEulerMethodRadioButton.Text = "метод Эйлера-Крамера";
            this.CramerEulerMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // VerletMethodRadioButton
            // 
            this.VerletMethodRadioButton.AutoSize = true;
            this.VerletMethodRadioButton.Location = new System.Drawing.Point(281, 38);
            this.VerletMethodRadioButton.Name = "VerletMethodRadioButton";
            this.VerletMethodRadioButton.Size = new System.Drawing.Size(90, 17);
            this.VerletMethodRadioButton.TabIndex = 13;
            this.VerletMethodRadioButton.Text = "метод Верле";
            this.VerletMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // BeemanMethodRadioButton
            // 
            this.BeemanMethodRadioButton.AutoSize = true;
            this.BeemanMethodRadioButton.Location = new System.Drawing.Point(383, 39);
            this.BeemanMethodRadioButton.Name = "BeemanMethodRadioButton";
            this.BeemanMethodRadioButton.Size = new System.Drawing.Size(98, 17);
            this.BeemanMethodRadioButton.TabIndex = 14;
            this.BeemanMethodRadioButton.Text = "метод Бимана";
            this.BeemanMethodRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BeemanMethodRadioButton);
            this.Controls.Add(this.VerletMethodRadioButton);
            this.Controls.Add(this.CramerEulerMethodRadioButton);
            this.Controls.Add(this.EulerMethodRadioButton);
            this.Controls.Add(this.createSystemButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.planetCountNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelingTimeBox);
            this.Controls.Add(this.simulationStepTimeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acceptParamsButton);
            this.Controls.Add(this.systemDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ParamsForm";
            this.Text = "ParamsForm";
            this.Load += new System.EventHandler(this.ParamsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView systemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planexXColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planexYColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planetSpeedXColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planetSpeedYColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planetMass;
        private System.Windows.Forms.Button acceptParamsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox simulationStepTimeBox;
        private System.Windows.Forms.TextBox modelingTimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown planetCountNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createSystemButton;
        private System.Windows.Forms.RadioButton EulerMethodRadioButton;
        private System.Windows.Forms.RadioButton CramerEulerMethodRadioButton;
        private System.Windows.Forms.RadioButton VerletMethodRadioButton;
        private System.Windows.Forms.RadioButton BeemanMethodRadioButton;
    }
}