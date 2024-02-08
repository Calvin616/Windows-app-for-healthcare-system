using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace HealthCare_Plus
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string connecttionString = "Data Source=CALVIN\\SQLEXPRESS;Initial Catalog=hospitalDB;Integrated Security=True";

            string fullname = Fullname.Text.Trim();
            string username = username1.Text.Trim();
            string password = password1.Text.Trim();
            string iduser = userid.Text.Trim();

            if (username1.Text == "" || password1.Text == "")
                MessageBox.Show("please fill the mandatory fields");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connecttionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlCon);
                    SqlCommand Cmd = new SqlCommand("INSERT INTO signup_table(FullName,UserName,Password,UserID) values(@FullName,@UserName,@Password,@UserID)", sqlCon);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.AddWithValue("@FullName", fullname);
                    Cmd.Parameters.AddWithValue("@UserName", username);
                    Cmd.Parameters.AddWithValue("@Password", password);
                    Cmd.Parameters.AddWithValue("@UserID", iduser);
                    //Cmd.ExecuteNonQuery();

                    sqlCon.Close();

                    MessageBox.Show("Signup is successful!");
                    Clear();

                    this.Hide();
                    Home_page ds = new Home_page();
                    ds.Show();
                }

            }
            void Clear()
            {
                Fullname.Clear();
                username1.Clear();
                password1.Clear();
                userid.Clear();
            }

        }
        
        


        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Log_in ds = new Log_in();
            ds.Show();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}
