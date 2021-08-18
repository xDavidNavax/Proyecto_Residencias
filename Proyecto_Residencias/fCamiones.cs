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
    public partial class fCamiones : Form
    {
        string Modo = "";
        public fCamiones()
        {
            InitializeComponent();
        }

       
        private void fCamiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.vCamiones' Puede moverla o quitarla según sea necesario.
            this.vCamionesTableAdapter.Fill(this.dbCrocDataSet.vCamiones);
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.tblSocios' Puede moverla o quitarla según sea necesario.
            this.tblSociosTableAdapter.Fill(this.dbCrocDataSet.tblSocios);
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.tblCamiones' Puede moverla o quitarla según sea necesario.
            this.tblCamionesTableAdapter.Fill(this.dbCrocDataSet.tblCamiones);
            this.CargaDatos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ModoEdicion(string modo)
        {
            switch (modo)
            {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.tblCamionesBindingNavigator.Enabled = true;
                    this.tblCamionesDataGridView.Enabled = true;
                    this.pnlDetalle.Enabled = false;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.tblCamionesBindingNavigator.Enabled = false;
                    this.tblCamionesDataGridView.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.tblCamionesBindingNavigator.Enabled = false;
                    this.tblCamionesDataGridView.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    break;
            }
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
                            this.tblCamionesTableAdapter.Insert((int)this.idSocioComboBox.SelectedValue, this.placatxt.Text,
                                this.colortxt.Text, this.metrostxt.Text, true);
                            break;
                        case "Actualizar":
                            int idCamion = int.Parse(this.idCamiontxt.Text);
                            this.tblCamionesTableAdapter.Update((int)this.idSocioComboBox.SelectedValue, this.placatxt.Text, this.colortxt.Text
                            , this.metrostxt.Text, true, idCamion);
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMenu f = new fMenu();
            f.ShowDialog();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Insertar");
            this.idCamiontxt.Text = "";            
            this.idSocioComboBox.SelectedIndex = 0;
            this.colortxt.Text = "";
            this.metrostxt.Text = "";
            this.placatxt.Text = "";
            this.Modo = "Insertar";
        }

        private void CargaSocio() {
            this.vSocioTableAdapter.Fill(this.dbCrocDataSet.vSocio);
            this.idSocioComboBox.DataSource = this.dbCrocDataSet.vSocio;
            this.idSocioComboBox.DisplayMember = "NombreCompleto";
            this.idSocioComboBox.ValueMember = "IdSocio";

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
                    int idCamion = int.Parse(this.idCamiontxt.Text);
                    this.tblCamionesTableAdapter.Delete(idCamion);
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
        private bool valida()
        {
            bool validado = true;
            if (this.colortxt.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.colortxt, "Campo requerido");
                this.errorProvider1.SetError(this.metrostxt, "Campo requerido");
                this.errorProvider1.SetError(this.placatxt, "Campo requerido");
            }




            return validado;
        }

        private void CargaDatos()
        {
            try
            {
                this.vCamionesTableAdapter.Fill(this.dbCrocDataSet.vCamiones);
                this.CargaSocio();
                this.ModoEdicion("Lectura");
                this.btnEliminar.Enabled = this.tblCamionesDataGridView.Rows.Count > 0;
                this.btnEditar.Enabled = this.tblCamionesDataGridView.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message.ToString());
            }
        }

        private void tblCamionesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblCamionesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.tblCamionesDataGridView.Rows.Count == 0 )
                {
                    return;
                }
                else
                {
                    this.idCamiontxt.Text = this.tblCamionesDataGridView.CurrentRow.Cells["IdCamion"].Value.ToString();
                    this.idSocioComboBox.SelectedValue = this.tblCamionesDataGridView.CurrentRow.Cells["IdSocio"].Value.ToString();
                    this.placatxt.Text = this.tblCamionesDataGridView.CurrentRow.Cells["Placa"].Value.ToString();
                    this.metrostxt.Text = this.tblCamionesDataGridView.CurrentRow.Cells["Metros"].Value.ToString();
                    this.colortxt.Text = this.tblCamionesDataGridView.CurrentRow.Cells["Color"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
