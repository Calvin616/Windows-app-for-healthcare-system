using Microsoft.VisualBasic;
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

namespace HealthCare_Plus
{
    public partial class doctors : Form
    {
        public doctors()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_page ds = new Home_page();
            ds.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
            


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_page ds = new Home_page();
            ds.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Docname = docname.Text.Trim();
            string pname = Pname.Text.Trim();
            string Department = depart.Text.Trim();
            string Contact = contact.Text.Trim();
            string DateTime = dateTime.Text.Trim();
            string Apid = aptid.Text.Trim();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            doctorprofiles ds = new doctorprofiles();
            ds.Show();
        }
    }
}
