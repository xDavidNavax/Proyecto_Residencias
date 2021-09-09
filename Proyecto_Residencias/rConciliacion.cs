using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Proyecto_Residencias
{
    public partial class rConciliacion : Form
    {
        public rConciliacion()
        {
            InitializeComponent();
        }

       private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMenu f = new fMenu();
            f.ShowDialog();
            this.Close();
        }    

        private void rConciliacion_Load(object sender, EventArgs e)
        {
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string FechaInicio = this.dtpFechaInicio.Value.ToString("yyyy/MM/dd");
            string FechaFin = this.dtpFechaFin.Value.ToString("yyyy/MM/dd");
            this.rConciliacionTableAdapter.Fill(this.dbCrocDataSet.rConciliacion,FechaInicio,FechaFin);          
            this.reportViewer1.RefreshReport();

        }
    }
}
