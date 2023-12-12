namespace SchoolMengerment
{
    partial class Attendance
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
            panel1 = new Panel();
            label1 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            button3 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 72);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(944, 72);
            label1.TabIndex = 0;
            label1.Text = "Attendance";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(22, 135);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(246, 33);
            textBox5.TabIndex = 24;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 99);
            label6.Name = "label6";
            label6.Size = new Size(246, 33);
            label6.TabIndex = 23;
            label6.Text = "Attendance Id :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 186);
            label2.Name = "label2";
            label2.Size = new Size(246, 33);
            label2.TabIndex = 23;
            label2.Text = "Student Id :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 222);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 33);
            textBox1.TabIndex = 24;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(343, 99);
            label3.Name = "label3";
            label3.Size = new Size(246, 33);
            label3.TabIndex = 23;
            label3.Text = "Create_by :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(343, 186);
            label4.Name = "label4";
            label4.Size = new Size(246, 33);
            label4.TabIndex = 23;
            label4.Text = "Create_at : ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 135);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 33);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 222);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 33);
            textBox3.TabIndex = 24;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(666, 99);
            label5.Name = "label5";
            label5.Size = new Size(246, 33);
            label5.TabIndex = 23;
            label5.Text = "Date Time Recorded :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(666, 135);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(246, 33);
            textBox4.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(22, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(890, 295);
            dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Attendance Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Student Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Date_time Recorded";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Create_by";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Create_at";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // button4
            // 
            button4.Location = new Point(166, 596);
            button4.Name = "button4";
            button4.Size = new Size(102, 35);
            button4.TabIndex = 26;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(22, 596);
            button1.Name = "button1";
            button1.Size = new Size(102, 35);
            button1.TabIndex = 27;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(666, 218);
            button5.Name = "button5";
            button5.Size = new Size(102, 35);
            button5.TabIndex = 29;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(810, 218);
            button3.Name = "button3";
            button3.Size = new Size(102, 35);
            button3.TabIndex = 30;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(810, 596);
            button6.Name = "button6";
            button6.Size = new Size(102, 35);
            button6.TabIndex = 31;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = true;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 643);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Attendance";
            Text = "Attendance";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox5;
        private Label label6;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button3;
        private Button button6;
    }
}