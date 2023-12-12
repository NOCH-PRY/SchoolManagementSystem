using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using SchoolMengerment;
using System.Data;

namespace SchoolMengerment
{
    public partial class frmLogin : Form
    {
        private SqlConnection connection;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string conString = "Server=DESKTOP-0O4DJ93;Initial Catalog=SchoolManagementDB;Integrated Security=True; User ID=sa;Password=Noch@@789";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            String Username, Password;
            Username = txtUsername.Text;
            Password = txtPassword.Text;

            try
            {
                String query = "SELECT * FROM [Users] WHERE Name = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    Username = txtUsername.Text;
                    Password = txtPassword.Text;

                    //page that needed to bee load next
                    frmDashboard form2 = new frmDashboard();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    //to focus username
                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
