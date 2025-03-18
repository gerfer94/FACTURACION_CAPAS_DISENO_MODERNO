using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Facturacion
{
    public partial class frmCRUDFacturas : Form
    {
        private Cls_Facturas factura = new Cls_Facturas();
        private int? idFactura = null;

        // Constructor para agregar nueva factura
        public frmCRUDFacturas()
        {
            InitializeComponent();
        }

        // Constructor para editar factura
        public frmCRUDFacturas(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
            CargarFactura(idFactura);
        }

        private void CargarFactura(int idFactura)
        {
            DataTable dtFactura = factura.ObtenerFacturaPorId(idFactura);
            if (dtFactura.Rows.Count > 0)
            {
                DataRow row = dtFactura.Rows[0];
                txtNumeroFactura.Text = row["IdFactura"].ToString();
                txtFechaRegistro.Text = row["Fecha"].ToString();
                txtCliente.Text = row["IdCliente"].ToString();
                txtEmpleado.Text = row["IdEmpleado"].ToString();
                txtDescuento.Text = row["Descuento"].ToString();
                txtTotalIVA.Text = row["Impuesto"].ToString();
                txtTotalFactura.Text = row["Total"].ToString();
                cmbEstadoFactura.SelectedIndex = Convert.ToInt32(row["IdEstado"]);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                DateTime fecha = DateTime.Parse(txtFechaRegistro.Text);
                int idCliente = int.Parse(txtCliente.Text);
                int idEmpleado = int.Parse(txtEmpleado.Text);
                float descuento = float.Parse(txtDescuento.Text);
                float impuesto = float.Parse(txtTotalIVA.Text);
                float total = float.Parse(txtTotalFactura.Text);
                int idEstado = cmbEstadoFactura.SelectedIndex;
                string usuario = "Admin";

                if (idFactura == null)
                {
                    if (factura.InsertarFactura(fecha, idCliente, idEmpleado, descuento, impuesto, total, idEstado, usuario))
                    {
                        MessageBox.Show("Factura guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (factura.ActualizarFactura((int)idFactura, fecha, idCliente, idEmpleado, descuento, impuesto, total, idEstado, usuario))
                    {
                        MessageBox.Show("Factura actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idFactura != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (factura.EliminarFactura((int)idFactura))
                    {
                        MessageBox.Show("Factura eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtTotalIVA.Text) ||
                string.IsNullOrWhiteSpace(txtTotalFactura.Text) ||
                string.IsNullOrWhiteSpace(txtFechaRegistro.Text) ||
                cmbEstadoFactura.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
