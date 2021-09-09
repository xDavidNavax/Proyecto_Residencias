using System;
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

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        private void rConciliacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.vConciliacion' Puede moverla o quitarla según sea necesario.
            this.vConciliacionTableAdapter.Fill(this.dbCrocDataSet.vConciliacion);

            this.reportViewer1.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
           

        }
    }
}
