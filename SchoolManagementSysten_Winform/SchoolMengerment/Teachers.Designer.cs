namespace SchoolMengerment
{
    partial class Teachers
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
            rdoF = new RadioButton();
            rdoM = new RadioButton();
            txtAdress = new TextBox();
            txtPhone = new TextBox();
            txtgradeId = new TextBox();
            txtTeacherid = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            labelphone = new Label();
            label4 = new Label();
            label2 = new Label();
            btnSave = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnExitTeacher = new Button();
            dtp_dob = new DateTimePicker();
            dtp_createat = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            txtteacherName = new TextBox();
            txt_Createby = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 54);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1194, 54);
            label1.TabIndex = 0;
            label1.Text = "Teacher";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdoF
            // 
            rdoF.Location = new Point(44, 164);
            rdoF.Margin = new Padding(3, 2, 3, 2);
            rdoF.Name = "rdoF";
            rdoF.Size = new Size(78, 25);
            rdoF.TabIndex = 22;
            rdoF.TabStop = true;
            rdoF.Text = "Female";
            rdoF.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            rdoM.Location = new Point(140, 164);
            rdoM.Margin = new Padding(3, 2, 3, 2);
            rdoM.Name = "rdoM";
            rdoM.Size = new Size(62, 25);
            rdoM.TabIndex = 21;
            rdoM.TabStop = true;
            rdoM.Text = "Male";
            rdoM.UseVisualStyleBackColor = true;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(316, 166);
            txtAdress.Margin = new Padding(3, 2, 3, 2);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(216, 26);
            txtAdress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(885, 105);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(216, 26);
            txtPhone.TabIndex = 20;
            // 
            // txtgradeId
            // 
            txtgradeId.Location = new Point(589, 105);
            txtgradeId.Margin = new Padding(3, 2, 3, 2);
            txtgradeId.Multiline = true;
            txtgradeId.Name = "txtgradeId";
            txtgradeId.Size = new Size(216, 26);
            txtgradeId.TabIndex = 14;
            // 
            // txtTeacherid
            // 
            txtTeacherid.Location = new Point(48, 105);
            txtTeacherid.Margin = new Padding(3, 2, 3, 2);
            txtTeacherid.Multiline = true;
            txtTeacherid.Name = "txtTeacherid";
            txtTeacherid.Size = new Size(216, 26);
            txtTeacherid.TabIndex = 13;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(44, 137);
            label9.Name = "label9";
            label9.Size = new Size(215, 25);
            label9.TabIndex = 11;
            label9.Text = "Gender";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(45, 199);
            label8.Name = "label8";
            label8.Size = new Size(215, 25);
            label8.TabIndex = 10;
            label8.Text = "Create at";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(316, 139);
            label3.Name = "label3";
            label3.Size = new Size(215, 25);
            label3.TabIndex = 9;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(885, 139);
            label7.Name = "label7";
            label7.Size = new Size(215, 25);
            label7.TabIndex = 8;
            label7.Text = "Create by";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(589, 139);
            label5.Name = "label5";
            label5.Size = new Size(215, 25);
            label5.TabIndex = 7;
            label5.Text = "DOB :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // labelphone
            // 
            labelphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelphone.Location = new Point(885, 79);
            labelphone.Name = "labelphone";
            labelphone.Size = new Size(215, 25);
            labelphone.TabIndex = 6;
            labelphone.Text = "Phone Number";
            labelphone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(589, 79);
            label4.Name = "label4";
            label4.Size = new Size(215, 25);
            label4.TabIndex = 12;
            label4.Text = "GradeID";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 79);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 5;
            label2.Text = "TeacherID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(696, 226);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 26);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // button5
            // 
            button5.Location = new Point(813, 226);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(89, 26);
            button5.TabIndex = 24;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(928, 226);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(89, 26);
            button3.TabIndex = 25;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(171, 623);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(89, 26);
            button4.TabIndex = 27;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnExitTeacher
            // 
            btnExitTeacher.Location = new Point(45, 623);
            btnExitTeacher.Margin = new Padding(3, 2, 3, 2);
            btnExitTeacher.Name = "btnExitTeacher";
            btnExitTeacher.Size = new Size(89, 26);
            btnExitTeacher.TabIndex = 28;
            btnExitTeacher.Text = "Exit";
            btnExitTeacher.UseVisualStyleBackColor = true;
            btnExitTeacher.Click += button1_Click;
            // 
            // dtp_dob
            // 
            dtp_dob.CustomFormat = "dd/MM/yyyy";
            dtp_dob.Format = DateTimePickerFormat.Custom;
            dtp_dob.Location = new Point(589, 166);
            dtp_dob.Margin = new Padding(3, 2, 3, 2);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(219, 23);
            dtp_dob.TabIndex = 30;
            // 
            // dtp_createat
            // 
            dtp_createat.CustomFormat = "dd/MM/yyyy";
            dtp_createat.Format = DateTimePickerFormat.Custom;
            dtp_createat.Location = new Point(45, 226);
            dtp_createat.Margin = new Padding(3, 2, 3, 2);
            dtp_createat.Name = "dtp_createat";
            dtp_createat.Size = new Size(219, 23);
            dtp_createat.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1091, 321);
            dataGridView1.TabIndex = 33;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(316, 79);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 5;
            label6.Text = "Teacher Name";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtteacherName
            // 
            txtteacherName.Location = new Point(316, 105);
            txtteacherName.Margin = new Padding(3, 2, 3, 2);
            txtteacherName.Multiline = true;
            txtteacherName.Name = "txtteacherName";
            txtteacherName.Size = new Size(216, 26);
            txtteacherName.TabIndex = 13;
            // 
            // txt_Createby
            // 
            txt_Createby.Location = new Point(885, 166);
            txt_Createby.Margin = new Padding(3, 2, 3, 2);
            txt_Createby.Multiline = true;
            txt_Createby.Name = "txt_Createby";
            txt_Createby.Size = new Size(216, 26);
            txt_Createby.TabIndex = 16;
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 677);
            Controls.Add(dataGridView1);
            Controls.Add(dtp_createat);
            Controls.Add(dtp_dob);
            Controls.Add(btnSave);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(btnExitTeacher);
            Controls.Add(rdoF);
            Controls.Add(rdoM);
            Controls.Add(txtAdress);
            Controls.Add(txt_Createby);
            Controls.Add(txtPhone);
            Controls.Add(txtgradeId);
            Controls.Add(txtteacherName);
            Controls.Add(txtTeacherid);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(labelphone);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Teachers";
            Text = "Techers";
            Load += Teachers_Load;
            Click += Teachers_Click;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton rdoF;
        private RadioButton rdoM;
        private TextBox txtAdress;
        private TextBox textBox7;
        private TextBox txtPhone;
        private TextBox txtgradeId;
        private TextBox txtTeacherid;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label7;
        private Label label5;
        private Label labelphone;
        private Label label4;
        private Label label2;
        private Button btnSave;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button btnExitTeacher;
        private DateTimePicker dtp_dob;
        private DateTimePicker dtp_createat;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txtteacherName;
        private TextBox txt_Createby;
    }
}