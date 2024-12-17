using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KasYayasan
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Documents\Kas.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand User_Login_Check = new SqlCommand("SELECT Username FROM [dbo].[user] WHERE Username =  '" + txtUsername.Text + "'", conn);
            SqlDataReader NameChecker = User_Login_Check.ExecuteReader();

            if (NameChecker.Read() == true)
            {
                NameChecker.Close();
                conn.Close();

                conn.Open();
                SqlCommand Login_Password_check = new SqlCommand("SELECT * FROM [dbo].[user] WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'", conn);
                SqlDataReader Password_Reader = Login_Password_check.ExecuteReader();

                if (Password_Reader.Read() == true)
                {
                    Password_Reader.Close();
                    conn.Close();


                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    Password_Reader.Close();
                    conn.Close();

                    txtPassword.Text = "";

                    MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                NameChecker.Close();
                conn.Close();

                MessageBox.Show("Username not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }
    }
}
