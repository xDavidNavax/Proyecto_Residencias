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
    public partial class fSocios : Form
    {
        string Modo = "";
        public fSocios()
        {
            InitializeComponent();
        }

        private void tblSociosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); 
            this.tblSociosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbCrocDataSet);

        }

        private void fSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbCrocDataSet.tblSocios' Puede moverla o quitarla según sea necesario.
            this.tblSociosTableAdapter.Fill(this.dbCrocDataSet.tblSocios);

        }

        private void CargaDatos() {
            try
            {
                this.tblSociosTableAdapter.Fill(this.dbCrocDataSet.tblSocios);
                this.ModoEdicion("Lectura");
                this.btnEliminar.Enabled = this.tblSociosDataGridView.Rows.Count > 0;
                this.btnEditar.Enabled = this.tblSociosDataGridView.Rows.Count > 0;
            }
            catch (Exception ex) {
                MessageBox.Show("Error " + ex.Message.ToString());
            }
            }


        private void ModoEdicion(string modo)
        {
            switch (modo)
            {
                case "Lectura":
                    this.pnlBotones.Enabled = true;
                    this.tblSociosBindingNavigator.Enabled = true;
                    this.tblSociosDataGridView.Enabled = true;
                    this.pnlDetalle.Enabled = false;
                    break;

                case "Insertar":
                    this.pnlBotones.Enabled = false;
                    this.tblSociosBindingNavigator.Enabled = false;
                    this.tblSociosDataGridView.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    break;

                case "Actualizar":
                    this.pnlBotones.Enabled = false;
                    this.tblSociosBindingNavigator.Enabled = false;
                    this.tblSociosDataGridView.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    break;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Está seguro de eliminar éste registro? ", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    //Ejecuta la consulta de Eliminar
                    int idSocio = int.Parse(this.idSocioTextBox.Text);
                    this.tblSociosTableAdapter.Delete(idSocio, nombreTextBox.Text,
                        primerApellidoTextBox.Text, segundoApellidoTextBox.Text, 
                        telefonoTextBox.Text, ciudadTextBox.Text,true);
                    MessageBox.Show("¡El registro se borró correctamente!");
                    this.CargaDatos();
                }
                else {
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Actualizar");
            this.Modo = "Actualizar";
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Lectura");
            this.CargaDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Insertar");
            this.idSocioTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.primerApellidoTextBox.Text = "";
            this.segundoApellidoTextBox.Text = "";
            this.telefonoTextBox.Text = "";
            this.ciudadTextBox.Text = "";
            this.Modo = "Insertar";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {         
            try
                {
                    switch (this.Modo)
                    {
                        case "Insertar":
                            this.tblSociosTableAdapter.Insert(this.nombreTextBox.Text, this.primerApellidoTextBox.Text,
                            this.segundoApellidoTextBox.Text, this.telefonoTextBox.Text, this.ciudadTextBox.Text, true);
                        break;

                        case "Actualizar":
                            int idSocio = int.Parse(this.idSocioTextBox.Text);
                            this.tblSociosTableAdapter.Update(this.nombreTextBox.Text,this.primerApellidoTextBox.Text,
                                this.segundoApellidoTextBox.Text,this.telefonoTextBox.Text,this.ciudadTextBox.Text,true,idSocio);
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
       
        private bool valida()
        {
            bool validado = true;
            if (this.nombreTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.nombreTextBox, "Campo requerido");
                this.errorProvider1.SetError(this.segundoApellidoTextBox, "Campo requerido");
                this.errorProvider1.SetError(this.primerApellidoTextBox, "Campo requerido");
                this.errorProvider1.SetError(this.telefonoTextBox, "Campo requerido");
                this.errorProvider1.SetError(this.ciudadTextBox, "Campo requerido");
            }




            return validado;
        }

        private void primerApellidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMenu f = new fMenu();
            f.ShowDialog();
            this.Close();
        }
    }
 }


    

