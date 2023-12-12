namespace SchoolMengerment
{
    partial class frmDashboard
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
            pictureBox1 = new PictureBox();
            btnAdmin = new Button();
            btnClass = new Button();
            btnTeacher = new Button();
            button1 = new Button();
            btnStudent = new Button();
            btnAttendance = new Button();
            panel2 = new Panel();
            label2 = new Label();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 53);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 163);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-4, 120);
            label1.Name = "label1";
            label1.Size = new Size(219, 43);
            label1.TabIndex = 0;
            label1.Text = "TEAM 3";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logo_HengMeas;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(48, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.SkyBlue;
            btnAdmin.ForeColor = Color.Blue;
            btnAdmin.Location = new Point(759, 399);
            btnAdmin.Margin = new Padding(3, 2, 3, 2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(220, 93);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Administrator";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += button5_Click;
            // 
            // btnClass
            // 
            btnClass.BackColor = Color.SkyBlue;
            btnClass.ForeColor = Color.Blue;
            btnClass.Location = new Point(759, 256);
            btnClass.Margin = new Padding(3, 2, 3, 2);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(220, 93);
            btnClass.TabIndex = 2;
            btnClass.Text = "Class";
            btnClass.UseVisualStyleBackColor = false;
            btnClass.Click += btnClass_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = Color.SkyBlue;
            btnTeacher.ForeColor = Color.Blue;
            btnTeacher.Location = new Point(394, 256);
            btnTeacher.Margin = new Padding(3, 2, 3, 2);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(220, 93);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "Techer";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(394, 110);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(220, 93);
            button1.TabIndex = 2;
            button1.Text = "Enrollment";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.SkyBlue;
            btnStudent.ForeColor = Color.Blue;
            btnStudent.Location = new Point(759, 110);
            btnStudent.Margin = new Padding(3, 2, 3, 2);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(220, 93);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += button2_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.SkyBlue;
            btnAttendance.ForeColor = Color.Blue;
            btnAttendance.Location = new Point(394, 399);
            btnAttendance.Margin = new Padding(3, 2, 3, 2);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(220, 93);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "Attendence";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, -2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1285, 53);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1283, 53);
            label2.TabIndex = 3;
            label2.Text = "School Mangment System";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.BackColor = Color.SkyBlue;
            button7.ForeColor = Color.Blue;
            button7.Location = new Point(46, 242);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(111, 31);
            button7.TabIndex = 2;
            button7.Text = "LOGOUT";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.SkyBlue;
            button8.ForeColor = Color.Blue;
            button8.Location = new Point(46, 287);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(111, 31);
            button8.TabIndex = 2;
            button8.Text = "EXIT";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 635);
            Controls.Add(button8);
            Controls.Add(panel2);
            Controls.Add(button7);
            Controls.Add(btnAdmin);
            Controls.Add(panel1);
            Controls.Add(btnAttendance);
            Controls.Add(btnClass);
            Controls.Add(button1);
            Controls.Add(btnTeacher);
            Controls.Add(btnStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDashboard";
            Text = "frmDashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btnAdmin;
        private Button btnClass;
        private Button btnTeacher;
        private Button button7;
        private Button btnStudent;
        private Button btnAttendance;
        private Panel panel2;
        private Button button8;
        private Label label2;
    }
}