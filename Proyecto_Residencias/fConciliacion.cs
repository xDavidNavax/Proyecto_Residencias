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
    public partial class fConciliacion : Form
    {
        public fConciliacion()
        {
            InitializeComponent();
        }

        private void fConciliacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.vCamiones' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.vConciliacion' Puede moverla o quitarla según sea necesario.
            this.vConciliacionTableAdapter.Fill(this.dbCrocDataSet.vConciliacion);

        }
    }
}
