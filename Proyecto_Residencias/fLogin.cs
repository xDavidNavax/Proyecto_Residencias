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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valida())
            {
                this.tblUsuarioTableAdapter.Fill(this.dbCrocDataSet.tblUsuario, this.txtUsuario.Text.Trim(), this.txtPassword.Text.Trim());
                if (this.dbCrocDataSet.tblUsuario.Rows.Count > 0)
                {
                    this.Hide();
                    fMenu f = new fMenu();
                    f.ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("El Usuario y/o Password son incorrectos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool Valida() {
            bool validado = true;
            this.errorProvider1.Clear();

            if (this.txtUsuario.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.txtUsuario,"Este campo es requerido.");
            }
            if (this.txtPassword.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.txtPassword, "Este campo es requerido.");
            }
            return validado;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
