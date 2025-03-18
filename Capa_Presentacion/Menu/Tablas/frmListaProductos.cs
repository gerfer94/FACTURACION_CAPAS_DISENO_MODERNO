using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Tablas
{
    public partial class frmListaProductos : Form
    {
        private Cls_Productos productos = new Cls_Productos();

        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                DataTable dt = productos.ObtenerProductos();
                dgvProductos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCRUDProductos frm = new frmCRUDProductos(0, "", "", 0m, 0m, 0, "", "", "");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProductos.SelectedRows[0];
                int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                string nombre = row.Cells["StrNombre"].Value?.ToString() ?? "";
                string codigo = row.Cells["StrCodigo"].Value?.ToString() ?? "";
                decimal precioCompra = row.Cells["NumPrecioCompra"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["NumPrecioCompra"].Value) : 0m;
                decimal precioVenta = row.Cells["NumPrecioVenta"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["NumPrecioVenta"].Value) : 0m;
                int stock = row.Cells["NumStock"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["NumStock"].Value) : 0;
                string detalles = row.Cells["StrDetalle"].Value?.ToString() ?? "";
                string foto = row.Cells["StrFoto"].Value?.ToString() ?? ""; // Asegura que tenga un valor
                string categoria = row.Cells["Categoria"].Value?.ToString() ?? ""; // Para la categoría del producto

                // Llamada corregida asegurando que "foto" tenga un valor
                frmCRUDProductos frm = new frmCRUDProductos(idProducto, nombre, codigo, precioCompra, precioVenta, stock, categoria, detalles, foto);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                    if (productos.EliminarProducto(idProducto))
                    {
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}