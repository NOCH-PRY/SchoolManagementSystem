namespace SchoolMengerment
{
    partial class Student
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
            label1 = new Label();
            panel1 = new Panel();
            student_id = new Label();
            txt_studentId = new TextBox();
            phoneNumber = new Label();
            txt_Phone = new TextBox();
            full_name = new Label();
            txt_fullName = new TextBox();
            address = new Label();
            txt_Address = new TextBox();
            dob = new Label();
            grade_id = new Label();
            txt_gradeId = new TextBox();
            section = new Label();
            txt_Section = new TextBox();
            gender = new Label();
            rdoM = new RadioButton();
            rdoF = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txt_Createby = new TextBox();
            createBy = new Label();
            createAt = new Label();
            btnExport = new Button();
            txt_Admissionby = new TextBox();
            admissionBy = new Label();
            dataGridView1 = new DataGridView();
            dtp_dob = new DateTimePicker();
            dtp_createat = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1194, 54);
            label1.TabIndex = 0;
            label1.Text = "Student";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 54);
            panel1.TabIndex = 1;
            // 
            // student_id
            // 
            student_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            student_id.Location = new Point(30, 70);
            student_id.Name = "student_id";
            student_id.Size = new Size(192, 25);
            student_id.TabIndex = 2;
            student_id.Text = "Student ID";
            student_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_studentId
            // 
            txt_studentId.Location = new Point(30, 98);
            txt_studentId.Margin = new Padding(3, 2, 3, 2);
            txt_studentId.Multiline = true;
            txt_studentId.Name = "txt_studentId";
            txt_studentId.Size = new Size(193, 26);
            txt_studentId.TabIndex = 1;
            txt_studentId.TextChanged += textBox1_TextChanged;
            // 
            // phoneNumber
            // 
            phoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumber.Location = new Point(30, 132);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(192, 25);
            phoneNumber.TabIndex = 2;
            phoneNumber.Text = "Phone Number";
            phoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(30, 159);
            txt_Phone.Margin = new Padding(3, 2, 3, 2);
            txt_Phone.Multiline = true;
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(193, 26);
            txt_Phone.TabIndex = 5;
            txt_Phone.TextChanged += textBox1_TextChanged;
            // 
            // full_name
            // 
            full_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            full_name.Location = new Point(304, 70);
            full_name.Name = "full_name";
            full_name.Size = new Size(192, 25);
            full_name.TabIndex = 2;
            full_name.Text = "Full Name";
            full_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_fullName
            // 
            txt_fullName.Location = new Point(304, 98);
            txt_fullName.Margin = new Padding(3, 2, 3, 2);
            txt_fullName.Multiline = true;
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(193, 26);
            txt_fullName.TabIndex = 2;
            txt_fullName.TextChanged += textBox1_TextChanged;
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            address.Location = new Point(304, 132);
            address.Name = "address";
            address.Size = new Size(192, 25);
            address.TabIndex = 2;
            address.Text = "Address";
            address.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(304, 159);
            txt_Address.Margin = new Padding(3, 2, 3, 2);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(193, 26);
            txt_Address.TabIndex = 6;
            txt_Address.TextChanged += textBox1_TextChanged;
            // 
            // dob
            // 
            dob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dob.Location = new Point(599, 70);
            dob.Name = "dob";
            dob.Size = new Size(192, 25);
            dob.TabIndex = 2;
            dob.Text = "DOB";
            dob.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grade_id
            // 
            grade_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grade_id.Location = new Point(599, 132);
            grade_id.Name = "grade_id";
            grade_id.Size = new Size(192, 25);
            grade_id.TabIndex = 2;
            grade_id.Text = "Class";
            grade_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_gradeId
            // 
            txt_gradeId.Location = new Point(599, 159);
            txt_gradeId.Margin = new Padding(3, 2, 3, 2);
            txt_gradeId.Multiline = true;
            txt_gradeId.Name = "txt_gradeId";
            txt_gradeId.Size = new Size(193, 26);
            txt_gradeId.TabIndex = 7;
            // 
            // section
            // 
            section.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            section.Location = new Point(906, 132);
            section.Name = "section";
            section.Size = new Size(202, 25);
            section.TabIndex = 2;
            section.Text = "Section";
            section.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Section
            // 
            txt_Section.Location = new Point(906, 159);
            txt_Section.Margin = new Padding(3, 2, 3, 2);
            txt_Section.Multiline = true;
            txt_Section.Name = "txt_Section";
            txt_Section.Size = new Size(202, 26);
            txt_Section.TabIndex = 8;
            txt_Section.TextChanged += textBox1_TextChanged;
            // 
            // gender
            // 
            gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gender.Location = new Point(906, 70);
            gender.Name = "gender";
            gender.Size = new Size(202, 25);
            gender.TabIndex = 2;
            gender.Text = "Gender";
            gender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rdoM
            // 
            rdoM.Location = new Point(906, 98);
            rdoM.Margin = new Padding(3, 2, 3, 2);
            rdoM.Name = "rdoM";
            rdoM.Size = new Size(59, 25);
            rdoM.TabIndex = 4;
            rdoM.TabStop = true;
            rdoM.Text = "Male";
            rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoF
            // 
            rdoF.Location = new Point(971, 98);
            rdoF.Margin = new Padding(3, 2, 3, 2);
            rdoF.Name = "rdoF";
            rdoF.Size = new Size(65, 25);
            rdoF.TabIndex = 4;
            rdoF.TabStop = true;
            rdoF.Text = "Female";
            rdoF.UseVisualStyleBackColor = true;
            rdoF.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(1048, 98);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 25);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 628);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(89, 26);
            button1.TabIndex = 16;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(124, 628);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(89, 26);
            button4.TabIndex = 17;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(219, 628);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(89, 26);
            button2.TabIndex = 6;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1032, 215);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 26);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(933, 215);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 26);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(836, 215);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 26);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txt_Createby
            // 
            txt_Createby.Location = new Point(304, 224);
            txt_Createby.Margin = new Padding(3, 2, 3, 2);
            txt_Createby.Multiline = true;
            txt_Createby.Name = "txt_Createby";
            txt_Createby.Size = new Size(193, 26);
            txt_Createby.TabIndex = 10;
            // 
            // createBy
            // 
            createBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createBy.Location = new Point(304, 197);
            createBy.Name = "createBy";
            createBy.Size = new Size(192, 25);
            createBy.TabIndex = 7;
            createBy.Text = "Create By";
            createBy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createAt
            // 
            createAt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createAt.Location = new Point(600, 197);
            createAt.Name = "createAt";
            createAt.Size = new Size(192, 25);
            createAt.TabIndex = 9;
            createAt.Text = "Create At";
            createAt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(974, 628);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(89, 26);
            btnExport.TabIndex = 11;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // txt_Admissionby
            // 
            txt_Admissionby.Location = new Point(31, 224);
            txt_Admissionby.Margin = new Padding(3, 2, 3, 2);
            txt_Admissionby.Multiline = true;
            txt_Admissionby.Name = "txt_Admissionby";
            txt_Admissionby.Size = new Size(193, 26);
            txt_Admissionby.TabIndex = 9;
            // 
            // admissionBy
            // 
            admissionBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            admissionBy.Location = new Point(31, 197);
            admissionBy.Name = "admissionBy";
            admissionBy.Size = new Size(192, 25);
            admissionBy.TabIndex = 12;
            admissionBy.Text = "Admission By";
            admissionBy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1091, 325);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dtp_dob
            // 
            dtp_dob.CustomFormat = "dd/MM/yyyy";
            dtp_dob.Format = DateTimePickerFormat.Short;
            dtp_dob.Location = new Point(600, 97);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(191, 23);
            dtp_dob.TabIndex = 3;
            // 
            // dtp_createat
            // 
            dtp_createat.CustomFormat = "dd/MM/yyyy";
            dtp_createat.Format = DateTimePickerFormat.Short;
            dtp_createat.Location = new Point(600, 227);
            dtp_createat.Name = "dtp_createat";
            dtp_createat.Size = new Size(192, 23);
            dtp_createat.TabIndex = 11;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 673);
            Controls.Add(dtp_createat);
            Controls.Add(dtp_dob);
            Controls.Add(dataGridView1);
            Controls.Add(txt_Admissionby);
            Controls.Add(admissionBy);
            Controls.Add(btnExport);
            Controls.Add(createAt);
            Controls.Add(txt_Createby);
            Controls.Add(createBy);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(rdoF);
            Controls.Add(radioButton3);
            Controls.Add(rdoM);
            Controls.Add(txt_Phone);
            Controls.Add(txt_Section);
            Controls.Add(txt_gradeId);
            Controls.Add(txt_Address);
            Controls.Add(txt_fullName);
            Controls.Add(txt_studentId);
            Controls.Add(gender);
            Controls.Add(section);
            Controls.Add(phoneNumber);
            Controls.Add(grade_id);
            Controls.Add(address);
            Controls.Add(dob);
            Controls.Add(full_name);
            Controls.Add(student_id);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private RadioButton rdoM;
        private RadioButton rdoF;
        private RadioButton radioButton3;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label student_id;
        private TextBox txt_studentId;
        private Label phoneNumber;
        private Label full_name;
        private TextBox txt_fullName;
        private Label dob;
        private TextBox txtDob;
        private Label gender;
        private TextBox txtPhone;
        private Label address;
        private TextBox txtAddress;
        private Label grade_id;
        private TextBox txtgradeId;
        private Label section;
        private TextBox txtSection;
        private TextBox txtCreateby;
        private Label createBy;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private TextBox txtcreateAt;
        private Label createAt;
        private Button btnExport;
        private TextBox textBox8;
        private Label label10;
        private TextBox txtAdmissionby;
        private Label admissionBy;
        private TextBox txt_Phone;
        private TextBox txt_Address;
        private TextBox txt_gradeId;
        private TextBox txt_Section;
        private TextBox txt_Createby;
        private TextBox txt_createAt;
        private TextBox txt_Admissionby;
        private DataGridView dataGridView1;
        private DateTimePicker dtp_dob;
        private DateTimePicker txt_createat;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtp_createat;
    }
}