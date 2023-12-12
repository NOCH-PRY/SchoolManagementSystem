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
    public partial class Teachers : Form
    {

        public Teachers()
        {
            InitializeComponent();
            DisplayData();
        }
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public string conString = "Server=DESKTOP-0O4DJ93;Initial Catalog=SchoolManagementDB;Integrated Security=True; User ID=sa;Password=Noch@@789";
        //SqlCommand cmd;
        //SqlDataAdapter adapt;


        int ID = 0;
        int x;

        private void DisplayData()
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Teachers", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            txtTeacherid.Text = "";
            txtteacherName.Text = "";
            txtgradeId.Text = "";
            txtPhone.Text = "";
            rdoF.Text = "";
            txtAdress.Text = "";
            dtp_dob.Text = "";
            txt_Createby.Text = "";
            dtp_createat.Text = "";
            ID = 0;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Teachers_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmDashboard form3 = new frmDashboard();
            form3.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Teachers", "server = DESKTOP-0O4DJ93; database = SchoolManagementDB; UID = sa; password = Noch@@789");
            DataSet ds = new DataSet();
            da.Fill(ds, "Teachers");
            dataGridView1.DataSource = ds.Tables["Teachers"].DefaultView;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeacherid.Text.Trim()))
            {
                MessageBox.Show("Please input TeacherID", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTeacherid.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtteacherName.Text.Trim()))
            {
                MessageBox.Show("Please input TeacherID", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtteacherName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtgradeId.Text.Trim()))
            {
                MessageBox.Show("Please input GradeID", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgradeId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Please input Phone Number", "Missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (rdoF.Checked == false && rdoM.Checked == false)
            {
                MessageBox.Show("Please select gender...");
                rdoF.Focus();
                return;
            }

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            //DateTime parsedDate;
            String teacherid, teachername, dob, phone, address, gradeId, createBy, createAt;
            string gender = rdoM.Checked ? "Male" : "Female";
            //string formattedDate = parsedDate.ToString("yyyy-MM-dd");
            teacherid = txtTeacherid.Text;
            teachername = txtteacherName.Text;
            phone = txtPhone.Text;
            gradeId = txtgradeId.Text;
            address = txtAdress.Text;
            dob = dtp_dob.Text;
            createBy = txt_Createby.Text;
            createAt = dtp_createat.Text;

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO Teachers(teacher_id, teacher_name,  dob,gender, address,grade_id, phone_number,  created_by, created_at) " +
                    "VALUES('" + txtTeacherid.Text.ToString() + "', '" + txtteacherName.Text.ToString() + "', @Gender, @DOB, '" + txtPhone.Text.ToString() + "', '" + txtAdress.Text.ToString() + "', '" + txtgradeId.Text.ToString() + "', '" + txt_Createby.Text.ToString() + "', @createAt)";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@createAt", createAt);

                //cmd.Parameters.AddWithValue("@DOB", DateTime.ParseExact(dob, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                //cmd.Parameters.AddWithValue("@createAt", DateTime.ParseExact(createAt, "dd/MM/yyyy", CultureInfo.InvariantCulture));

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

        private void dtp_dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Teachers_Click(object sender, EventArgs e)
        {

        }
    }
}
