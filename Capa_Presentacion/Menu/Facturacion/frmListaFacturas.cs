using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Facturacion
{
    public partial class frmListaFacturas : Form
    {
        private Cls_Facturas facturas = new Cls_Facturas();

        public frmListaFacturas()
        {
            InitializeComponent();
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            dgvFacturas.DataSource = facturas.ObtenerFacturas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCRUDFacturas frm = new frmCRUDFacturas();
            frm.ShowDialog();
            CargarFacturas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0)
            {
                int idFactura = Convert.ToInt32(dgvFacturas.SelectedRows[0].Cells["IdFactura"].Value);
                frmCRUDFacturas frm = new frmCRUDFacturas(idFactura);
                frm.ShowDialog();
                CargarFacturas();
            }
            else
            {
                MessageBox.Show("Seleccione una factura para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0)
            {
                int idFactura = Convert.ToInt32(dgvFacturas.SelectedRows[0].Cells["IdFactura"].Value);
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (facturas.EliminarFactura(idFactura))
                    {
                        MessageBox.Show("Factura eliminada correctamente.");
                        CargarFacturas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la factura.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura para eliminar.");
            }
        }
    }
}
