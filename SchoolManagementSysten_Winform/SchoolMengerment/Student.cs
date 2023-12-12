using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMengerment
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            DisplayData();
        }

        SqlCommand cmd;
        SqlDataAdapter adapt;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string conString = "Server=DESKTOP-0O4DJ93;Initial Catalog=SchoolManagementDB;Integrated Security=True; User ID=sa;Password=Noch@@789";
        //SqlCommand cmd;
        //SqlDataAdapter adapt;


        int ID = 0;
        int x;

        private void button1_Click(object sender, EventArgs e)
        {
            frmDashboard form2 = new frmDashboard();
            form2.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_studentId.Text.Trim()))
            {
                MessageBox.Show("Please input StudentID", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_studentId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_fullName.Text.Trim()))
            {
                MessageBox.Show("Please input Full Name", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fullName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dtp_dob.Text.Trim()))
            {
                MessageBox.Show("Please input DOB", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_dob.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Phone.Text.Trim()))
            {
                MessageBox.Show("Please input Phone Number", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Phone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Address.Text.Trim()))
            {
                MessageBox.Show("Please input Address", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Address.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_gradeId.Text.Trim()))
            {
                MessageBox.Show("Please input GradeID", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gradeId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Section.Text.Trim()))
            {
                MessageBox.Show("Please input Section", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Section.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Admissionby.Text.Trim()))
            {
                MessageBox.Show("Please input AdmissionBy", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Admissionby.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Createby.Text.Trim()))
            {
                MessageBox.Show("Please input CreateBy", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Createby.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dtp_createat.Text.Trim()))
            {
                MessageBox.Show("Please input CreateAt", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_createat.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            String studentId, fullName, dob, phone, address, gradeId, section, admissionBy, createBy, createAt;
            string gender = rdoM.Checked ? "Male" : "Female";
            studentId = txt_studentId.Text;
            fullName = txt_fullName.Text;
            dob = dtp_dob.Text;
            phone = txt_Phone.Text;
            address = txt_Address.Text;
            gradeId = txt_gradeId.Text;
            section = txt_Section.Text;
            admissionBy = txt_Admissionby.Text;
            createBy = txt_Createby.Text;
            createAt = dtp_createat.Text;

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO Students(student_id, full_name, gender, dob, phone_number, address, grade_id, section, admission_by, created_by, created_at) " +
                    "VALUES('" + txt_studentId.Text.ToString() + "', '" + txt_fullName.Text.ToString() + "', @Gender, '" + dtp_dob.Text.ToString() + "', '" + txt_Phone.Text.ToString() + "', '" + txt_Address.Text.ToString() + "', '" + txt_gradeId.Text.ToString() + "', '" + txt_Section.Text.ToString() + "', '" + txt_Admissionby.Text.ToString() + "', '" + txt_Createby.Text.ToString() + "', '" + dtp_createat.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succeessful");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        private void DisplayData()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Students", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        // Clear Data
        private void ClearData()
        {
            txt_studentId.Text = "";
            txt_fullName.Text = "";
            dtp_dob.Text = "";
            txt_Phone.Text = "";
            txt_Address.Text = "";
            txt_gradeId.Text = "";
            txt_Section.Text = "";
            txt_Admissionby.Text = "";
            txt_Createby.Text = "";
            dtp_createat.Text = "";
            ID = 0;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DataGridViewRow n = dataGridView1.Rows[0];
            n.Cells[1].Value = txt_studentId.Text;
            n.Cells[2].Value = txt_fullName.Text;
            n.Cells[7].Value = txt_gradeId.Text;
            n.Cells[4].Value = dtp_dob.Text.ToString();
            n.Cells[3].Value = rdoM.Text;
            n.Cells[5].Value = txt_Phone.Text;
            n.Cells[6].Value = txt_Address.Text;
            n.Cells[8].Value = txt_Section.Text;
            n.Cells[9].Value = txt_Admissionby.Text;
            n.Cells[10].Value = txt_Createby.Text;
            n.Cells[11].Value = dtp_createat.Text.ToString();



            if (txt_studentId.Text != "" && txt_fullName.Text != "" && txt_Phone.Text != "" && txt_Address.Text != "" && txt_gradeId.Text != "" && txt_Section.Text != "" && txt_Admissionby.Text != "" && txt_Createby.Text != "")
            {
                SqlConnection conn = new SqlConnection(conString);
                string qUpdate = "UPDATE Students SET txt_studentId=@studentid, full_name=@fullname, gender=@gender,dob=@dob, phone_number=@phone, address=@address, grade_id=@gradeid, section=@section, admission_by=@adnissionby, created_by=@createby, created_at=@createat where ID=@id";
                SqlCommand cmd = new SqlCommand(qUpdate, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@studentid", txt_studentId.Text);
                cmd.Parameters.AddWithValue("@fullname", txt_fullName.Text);
                cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@gradeid", txt_gradeId.Text);
                cmd.Parameters.AddWithValue("@section", txt_Section.Text);
                cmd.Parameters.AddWithValue("@adnissionby", txt_Admissionby.Text);
                cmd.Parameters.AddWithValue("@createby", txt_Createby.Text);
                cmd.Parameters.AddWithValue("@createat", txt_createat.Text);
                cmd.Parameters.AddWithValue("@gender", rdoM.Text);
                cmd.Parameters.AddWithValue("@dob", dtp_dob.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", "server = DESKTOP-0O4DJ93; database = SchoolManagementDB; UID = sa; password = Noch@@789");
            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            dataGridView1.DataSource = ds.Tables["Students"].DefaultView;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            x = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(x);

            SqlConnection conn = new SqlConnection(conString);
            if (x != 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROMStudents WHERE  ID=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", x);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            x = e.RowIndex;
            DataGridViewRow R = dataGridView1.Rows[x];
            txt_studentId.Text = R.Cells[1].Value.ToString();
            txt_fullName.Text = R.Cells[2].Value.ToString();
            dtp_dob.Text = R.Cells[4].Value.ToString();
            rdoM.Text = R.Cells[3].Value.ToString();
            txt_Phone.Text = R.Cells[5].Value.ToString();
            txt_Address.Text = R.Cells[6].Value.ToString();
            txt_gradeId.Text = R.Cells[7].Value.ToString();
            txt_Section.Text = R.Cells[8].Value.ToString();
            txt_Admissionby.Text = R.Cells[9].Value.ToString();
            txt_Createby.Text = R.Cells[10].Value.ToString();
            dtp_createat.Text = R.Cells[11].Value.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
