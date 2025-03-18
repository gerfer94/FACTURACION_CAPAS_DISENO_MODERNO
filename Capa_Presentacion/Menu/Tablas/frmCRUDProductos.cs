using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Tablas
{
    public partial class frmCRUDProductos : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        private int productoId = 0;
        private readonly Cls_Productos productoNegocio = new Cls_Productos();

        public frmCRUDProductos()
        {
            InitializeComponent();
            CargarCategorias();
            btnAgregarProducto.Click -= btnAgregarProducto_Click;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
        }

        public frmCRUDProductos(int id, string nombre, string codigo, decimal precioCompra, decimal precioVenta, int stock, string descripcionCategoria, string detalles, string foto)
        {
            InitializeComponent();
            productoId = id;
            txtNombre.Text = nombre;
            txtCodigo.Text = codigo;
            txtPrecioCompra.Text = precioCompra.ToString("F2");
            txtPrecioVenta.Text = precioVenta.ToString("F2");
            txtStock.Text = stock.ToString();
            txtDetalles.Text = detalles;
            txtRutaFoto.Text = foto;
            pbFoto.ImageLocation = foto;

            CargarCategorias();
            cmbCategoria.SelectedItem = descripcionCategoria;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                InsertarProducto();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (productoId == 0)
                    InsertarProducto();
                else
                    ActualizarProducto();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoId != 0 && MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EliminarProducto();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRutaFoto.Text = openFileDialog.FileName;
                    pbFoto.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (productoId != 0)
            {
                ActualizarProducto();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCategorias()
        {
            cmbCategoria.DataSource = productoNegocio.ObtenerCategorias();
            cmbCategoria.DisplayMember = "StrDescripcion";
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void InsertarProducto()
        {
            try
            {
                productoNegocio.InsertarProducto(
                    txtNombre.Text,
                    txtCodigo.Text,
                    Convert.ToDecimal(txtPrecioCompra.Text),
                    Convert.ToDecimal(txtPrecioVenta.Text),
                    Convert.ToInt32(txtStock.Text),
                    Convert.ToInt32(cmbCategoria.SelectedValue),
                    txtDetalles.Text,
                    txtRutaFoto.Text,
                    "Admin"
                );

                MessageBox.Show("Producto agregado correctamente.");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProducto()
        {
            try
            {
                productoNegocio.ActualizarProducto(
                    productoId,
                    txtNombre.Text,
                    txtCodigo.Text,
                    Convert.ToDecimal(txtPrecioCompra.Text),
                    Convert.ToDecimal(txtPrecioVenta.Text),
                    Convert.ToInt32(txtStock.Text),
                    Convert.ToInt32(cmbCategoria.SelectedValue),
                    txtDetalles.Text,
                    txtRutaFoto.Text,
                    "Admin"
                );

                MessageBox.Show("Producto actualizado correctamente.");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarProducto()
        {
            try
            {
                productoNegocio.EliminarProducto(productoId);
                MessageBox.Show("Producto eliminado correctamente.");
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            errorProvider.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider.SetError(txtCodigo, "El código es obligatorio.");
                valido = false;
            }
            if (!decimal.TryParse(txtPrecioCompra.Text, out _))
            {
                errorProvider.SetError(txtPrecioCompra, "Precio de compra inválido.");
                valido = false;
            }
            if (!decimal.TryParse(txtPrecioVenta.Text, out _))
            {
                errorProvider.SetError(txtPrecioVenta, "Precio de venta inválido.");
                valido = false;
            }
            if (!int.TryParse(txtStock.Text, out _))
            {
                errorProvider.SetError(txtStock, "Stock inválido.");
                valido = false;
            }

            return valido;
        }
    }
}
