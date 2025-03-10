using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Seguridad
{
    public partial class frmCRUDEmpleados : Form
    {
        private Cls_Empleados empleados = new Cls_Empleados();
        private DataRow empleado;

        public frmCRUDEmpleados(int? idEmpleado = null)
        {
            InitializeComponent();

            if (idEmpleado.HasValue)
            {
                empleado = empleados.ObtenerEmpleado(idEmpleado.Value);
                CargarDatosEmpleado();
            }
            else
            {
                empleado = empleados.ObtenerListaEmpleados().NewRow();
            }
        }

        private void CargarDatosEmpleado()
        {
            if (empleado != null)
            {
                txtNombre.Text = empleado["strNombre"].ToString();
                txtDocumento.Text = empleado["NumDocumento"].ToString();
                txtDireccion.Text = empleado["StrDireccion"].ToString();
                txtTelefono.Text = empleado["StrTelefono"].ToString();
                txtEmail.Text = empleado["StrEmail"].ToString();
                cmbRolEmpleado.Text = empleado["IdRolEmpleado"].ToString();
                dtpFechaIngreso.Value = Convert.ToDateTime(empleado["DtmIngreso"]);
                dtpFechaRetiro.Value = empleado["DtmRetiro"] != DBNull.Value ? Convert.ToDateTime(empleado["DtmRetiro"]) : DateTime.Now;
                txtDatosAdicionales.Text = empleado["strDatosAdicionales"].ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (empleado == null)
            {
                MessageBox.Show("Error: No se ha podido cargar la información del empleado.");
                return;
            }

            MessageBox.Show("Guardando empleado con Nombre: " + txtNombre.Text + " y Documento: " + txtDocumento.Text);

            empleado["strNombre"] = txtNombre.Text;
            empleado["NumDocumento"] = txtDocumento.Text;
            empleado["StrDireccion"] = txtDireccion.Text;
            empleado["StrTelefono"] = txtTelefono.Text;
            empleado["StrEmail"] = txtEmail.Text;
            empleado["IdRolEmpleado"] = cmbRolEmpleado.Text;
            empleado["DtmIngreso"] = dtpFechaIngreso.Value;
            empleado["DtmRetiro"] = dtpFechaRetiro.Checked ? (object)dtpFechaRetiro.Value : DBNull.Value;
            empleado["strDatosAdicionales"] = txtDatosAdicionales.Text;

            // Llamar al método y capturar el mensaje devuelto
            string resultado = empleados.GuardarEmpleado(empleado);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Si el mensaje indica éxito, cerrar el formulario
            if (resultado.Contains("✅"))
            {
                this.Close();
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
