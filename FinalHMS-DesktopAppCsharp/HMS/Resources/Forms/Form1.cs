﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS
{
    public partial class HMS : Form
    {
        public HMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin a = new AdminLogin();
            a.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorLogin d = new DoctorLogin();
            d.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientLogin p = new PatientLogin();
            p.Show();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            ReceptionistLogin r = new ReceptionistLogin();
            r.Show();
        }

        private void HMS_Load(object sender, EventArgs e)
        {

        }
    }
}
