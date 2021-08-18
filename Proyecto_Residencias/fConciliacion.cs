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
    public partial class fConciliacion : Form
    {
        string Modo = "";
        public fConciliacion()
        {
            InitializeComponent();
        }
        private void CargaDatos()
        {
            try
            {
                this.vCamionesTableAdapter.Fill(this.dbCrocDataSet.vCamiones);
                this.vConciliacionTableAdapter.Fill(this.dbCrocDataSet.vConciliacion);
                this.ModoEdicion("Lectura");
                this.btnEliminar.Enabled = this.vConciliacionDataGridView.Rows.Count > 0;
                this.btnEditar.Enabled = this.vConciliacionDataGridView.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message.ToString());
            }
        }

        private void ModoEdicion(string modo)
        {
            switch (modo)
            {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.vConciliacionBindingNavigator.Enabled = true;
                    this.vConciliacionDataGridView.Enabled = true;
                    this.pnlDetalle.Enabled = false;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.vConciliacionBindingNavigator.Enabled = false;
                    this.vConciliacionDataGridView.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.vConciliacionBindingNavigator.Enabled = false;
                    this.vConciliacionDataGridView.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    break;
            }
        }

        private void fConciliacion_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Insertar");
            this.dtpFecha.Value = DateTime.Now;
            this.txtIdConciliacion.Text = "";
            this.cboSocio.SelectedIndex = 0;
            this.nudMetros.Value = 7;
            this.nudCantidad.Value = 1;
            this.nudPrecio.Value = 1;
            this.txtMaterial.Text = "";
            this.Modo = "Insertar";
        
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Actualizar");
            this.Modo = "Actualizar";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Está seguro de eliminar éste registro? ", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //Ejecuta la consulta de Eliminar
                    int idC = int.Parse(this.txtIdConciliacion.Text);
                    this.tblConciliacionTableAdapter.Delete(idC);
                    MessageBox.Show("¡El registro se borró correctamente!");
                    this.CargaDatos();
                }
                else
                {
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Lectura");
            this.CargaDatos();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMenu f = new fMenu();
            f.ShowDialog();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                try
                {
                    switch (this.Modo)
                    {
                        case "Insertar":
                            this.tblConciliacionTableAdapter.Insert((int)this.cboSocio.SelectedValue, this.dtpFecha.Value, (int)this.nudCantidad.Value,
                                this.txtMaterial.Text, (decimal)this.nudPrecio.Value, true);
                            break;
                        case "Actualizar":
                            int idC = int.Parse(this.txtIdConciliacion.Text);
                            this.tblConciliacionTableAdapter.Update((int)this.cboSocio.SelectedValue, this.dtpFecha.Value.ToString(), (int)this.nudCantidad.Value,
                                this.txtMaterial.Text, (decimal)this.nudPrecio.Value, true,idC);
                            break;

                    }
                    MessageBox.Show("Informacion guardada correctamente.");
                    this.CargaDatos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
            }
        }

        private bool valida()
        {
            bool validado = true;
            if (this.txtMaterial.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.txtMaterial, "Campo requerido");              
            }
            return validado;
        }

        private void vConciliacionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.vConciliacionDataGridView.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    this.txtIdConciliacion.Text = this.vConciliacionDataGridView.CurrentRow.Cells["IdConciliacion"].Value.ToString();
                    this.cboSocio.SelectedValue = this.vConciliacionDataGridView.CurrentRow.Cells["IdCamion"].Value.ToString();
                    this.dtpFecha.Value = DateTime.Parse(this.vConciliacionDataGridView.CurrentRow.Cells["Fecha"].Value.ToString());
                    this.nudMetros.Value = int.Parse(this.vConciliacionDataGridView.CurrentRow.Cells["Metros"].Value.ToString());
                    this.nudCantidad.Value = int.Parse(this.vConciliacionDataGridView.CurrentRow.Cells["Cantidad"].Value.ToString());
                    this.nudPrecio.Value = decimal.Parse(this.vConciliacionDataGridView.CurrentRow.Cells["Precio"].Value.ToString());
                    this.txtMaterial.Text = this.vConciliacionDataGridView.CurrentRow.Cells["Material"].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
