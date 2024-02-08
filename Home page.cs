using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home_page ds = new Home_page();
            ds.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up ds = new Sign_up();
            ds.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 ds = new Form1();
            ds.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_profile ds = new user_profile();
            ds.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patientslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Patients ds = new Patients();
            ds.Show();
        }

        private void doctorlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            doctors ds = new doctors();
            ds.Show();


        }

        private void appointmentlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Appointments ds = new Appointments();
            ds.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Healthcare_resources ds = new Healthcare_resources();
            ds.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Billing_and_Invoice ds = new Billing_and_Invoice();
            ds.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Available_rooms_and_theaters ds = new Available_rooms_and_theaters();
            ds.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medication_records ds = new Medication_records();
            ds.Show();
        }
    }
}
