using System;
using System.Linq;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Tablas
{
    public partial class frmCRUDCliente : Form
    {
        private Cls_Cliente cliente = new Cls_Cliente();
        private int clienteID = 0;
        private bool esEdicion = false;

        public frmCRUDCliente()
        {
            InitializeComponent();
        }

        public frmCRUDCliente(int idCliente)
        {
            InitializeComponent();
            this.clienteID = idCliente;
            this.esEdicion = true;
            this.lblTitulo.Text = "Editar Cliente";
            CargarCliente();
        }

        private void CargarCliente()
        {
            cliente = cliente.ObtenerClientePorID(clienteID);
            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtDocumento.Text = cliente.Documento.ToString();
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
                txtFechaModifica.Text = cliente.FechaModifica.ToString("yyyy-MM-dd HH:mm:ss");
                txtUsuarioModifica.Text = cliente.UsuarioModifica;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Documento = long.Parse(txtDocumento.Text);
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Email = txtEmail.Text;
                cliente.FechaModifica = DateTime.Now;
                cliente.UsuarioModifica = txtUsuarioModifica.Text;

                bool resultado = cliente.GuardarCliente();

                if (resultado)
                {
                    MessageBox.Show(esEdicion ? "Cliente actualizado con éxito." : "Cliente registrado con éxito.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            errorProvider.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }
            if (!long.TryParse(txtDocumento.Text, out _))
            {
                errorProvider.SetError(txtDocumento, "Ingrese un documento válido.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider.SetError(txtDireccion, "La dirección es obligatoria.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || !txtTelefono.Text.All(char.IsDigit))
            {
                errorProvider.SetError(txtTelefono, "Ingrese un teléfono válido.");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                errorProvider.SetError(txtEmail, "Ingrese un email válido.");
                esValido = false;
            }
            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
