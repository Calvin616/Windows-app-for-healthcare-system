using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HealthCare_Plus
{
    public partial class Log_in : Form
    {
        




        public Log_in()
        {
            InitializeComponent();
        }

        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connecttionString = "Data Source=CALVIN\\SQLEXPRESS;Initial Catalog=hospitalDB;Integrated Security=True";

            string Username = username.Text.Trim();
            string Userid = userid.Text.Trim();
            string Password = password.Text.Trim();

            if (username.Text == "" || userid.Text == "" || password.Text == "")
                MessageBox.Show("please fill all correct detalis");

            using (SqlConnection sqlCon = new SqlConnection(connecttionString))
            {
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand("NewLogin", sqlCon);
                SqlCommand Cmd = new SqlCommand("INSERT INTO Login_table (UserName, UserID, Password) VALUES (@UserName, @UserID, @Password)", sqlCon);
                Cmd.Parameters.AddWithValue("@UserName", username);
                Cmd.Parameters.AddWithValue("@UserID", userid);
                Cmd.Parameters.AddWithValue("@Password", password);
                //sqlcmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Login successful!");
                Clear();

                this.Hide();
                Home_page ds = new Home_page();
                ds.Show();
            }
        }
        void Clear()
        {
            username.Clear();
            password.Clear();
            userid.Clear();
        }






            

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Sign_up ds = new Sign_up();
            ds.Show();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
