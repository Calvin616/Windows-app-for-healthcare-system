﻿using System;
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
    public partial class Available_rooms_and_theaters : Form
    {
        public Available_rooms_and_theaters()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_page ds = new Home_page();
            ds.Show();
        }
    }
}
