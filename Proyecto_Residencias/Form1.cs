﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Residencias
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCamiones f = new fCamiones();
            f.ShowDialog();
            this.Close();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSocios f = new fSocios();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fConciliacion f = new fConciliacion();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            rConciliacion f = new rConciliacion();
            f.ShowDialog();
            this.Close();
        }
    }
}
