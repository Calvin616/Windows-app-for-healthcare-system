using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthCare_Plus
{
    public partial class Patients : Form
    {
        


        public Patients()
        {
            InitializeComponent();
        }
        

        

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_page ds = new Home_page();
            ds.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            

            string PatientName = Pname.Text.Trim();
            string address = Address.Text.Trim();
            string contact = Contact.Text.Trim();
            string gender = Gender.Text.Trim();
            string blood = Blood.Text.Trim();
            string ptage = Age.Text.Trim();
            string pid = Pid.Text.Trim();



            {

                SqlConnection sqlcon = new SqlConnection("Data Source=CALVIN\\SQLEXPRESS;Initial Catalog=hospitalDB;Integrated Security=True");
                sqlcon.Open();
                //SqlCommand sqlcmd = new SqlCommand("AddPatient", sqlcon);
                //SqlCommand Cmd = new SqlCommand("INSERT INTO VALUES Patient_table @PatientName, @Address, @Contact, @Gender, @BloodGroup, @Age , @PatientID", sqlcon);
                string insertQuery = "INSERT INTO Patient_table (PatientName , Address, Contact, Gender, BloodGroup, Age, PatientID) " +
                                     "VALUES (@PatientName, @Address, @Contact, @Gender, @BloodGroup, @Age, @PatientID)";
                SqlCommand sqlcmd = new SqlCommand(insertQuery, sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@PatientName", Pname.Text);
                sqlcmd.Parameters.AddWithValue("@Address", Address.Text);
                sqlcmd.Parameters.AddWithValue("@Contact", Contact.Text);
                sqlcmd.Parameters.AddWithValue("@Gender", Gender.Text);
                sqlcmd.Parameters.AddWithValue("@BloodGroup", Blood.Text);
                sqlcmd.Parameters.AddWithValue("@Age", int.Parse(Age.Text));
                sqlcmd.Parameters.AddWithValue("@PatientID",int.Parse(Pid.Text));
                //sqlcmd.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Patient add successful!");

                this.Hide();
                Home_page ds = new Home_page();
                ds.Show();


            }

        }
        void Clear()
        {
            Pname.Clear();
            Address.Clear();
            Contact.Clear();
            Age.Clear();
            Blood.Clear();
            Gender.Items.Clear();
            Pid.Clear();
        }
    





        

        private void bloodgroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }
    }
}
            
        
    





