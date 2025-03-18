using System;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Tablas
{
    public partial class frmListaCategoriaProductos : Form
    {
        public frmListaCategoriaProductos()
        {
            InitializeComponent();
            this.Load += frmListaCategoriaProductos_Load;
        }

        private void frmListaCategoriaProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            // Asegurar que haya una columna en el DataGridView
            if (dgvCategorias.Columns.Count == 0)
            {
                dgvCategorias.Columns.Add("Categoria", "Categoría de Producto");
            }

            // Limpiar filas antes de cargar nuevas
            dgvCategorias.Rows.Clear();

            // Agregar datos de ejemplo
            dgvCategorias.Rows.Add("Electrónica");
            dgvCategorias.Rows.Add("Ropa");
            dgvCategorias.Rows.Add("Alimentos");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEditar_Click(object sender, EventArgs e)
        {
            //frmCRUDCategoriaProducto crudForm = new frmCRUDCategoriaProducto();
            //crudForm.ShowDialog();

            // Recargar la lista después de cerrar el formulario CRUD
            CargarCategorias();
        }
    }
}


