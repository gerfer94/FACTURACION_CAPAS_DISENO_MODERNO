using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Seguridad
{
    public partial class frmCRUDAdminSeguridad : Form
    {
        private readonly Cls_AdminSeguridad adminSeguridad;
        private readonly string idSeguridad;

        public frmCRUDAdminSeguridad(string idSeguridad = "", string idEmpleado = "", string usuario = "", string clave = "", DateTime? fechaModifica = null, string usuarioModifico = "")
        {
            InitializeComponent();
            adminSeguridad = new Cls_AdminSeguridad();

            // Se asegura de que la clave se vea en texto plano
            txtClave.UseSystemPasswordChar = false;

            if (!string.IsNullOrEmpty(idSeguridad))
            {
                this.idSeguridad = idSeguridad;
                txtIdEmpleado.Text = idEmpleado;
                txtUsuario.Text = usuario;
                dtpFechaModifica.Value = fechaModifica ?? DateTime.Now;
                txtUsuarioModifico.Text = usuarioModifico;
                txtClave.Text = clave;
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                btnGuardar.Text = "Agregar";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recoger los datos desde el formulario
                int idEmpleado = int.Parse(txtIdEmpleado.Text);
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;
                string usuarioModifico = txtUsuarioModifico.Text;

                int resultado;

                // Si tenemos un idSeguridad (es decir, estamos actualizando)
                if (!string.IsNullOrEmpty(idSeguridad))
                {
                    // Llamar al método de modificación
                    resultado = adminSeguridad.ModificarAdministrador(idEmpleado, usuario, clave, usuarioModifico);
                }
                else
                {
                    // Si no, llamamos al método de agregar
                    resultado = adminSeguridad.AgregarAdministrador(idEmpleado, usuario, clave, usuarioModifico);
                }

                if (resultado > 0)
                {
                    MessageBox.Show("Operación realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
