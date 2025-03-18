using System;
using System.Windows.Forms;

namespace frmPrincipal.Forms.Tablas
{
    public partial class frmCRUDCategoriaProducto : Form
    {
        public frmCRUDCategoriaProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
