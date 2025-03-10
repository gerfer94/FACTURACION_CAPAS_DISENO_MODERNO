using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios; // Importa la capa de lógica de negocios

namespace Capa_Presentacion.Menu.Seguridad
{
    public partial class frmListaAdminSeguridad : Form
    {
        private readonly Cls_AdminSeguridad _adminSeguridad = new Cls_AdminSeguridad(); // Instancia de la clase de lógica de negocio

        public frmListaAdminSeguridad()
        {
            InitializeComponent();
            CargarAdministradores();
        }

        // Método para cargar la lista de administradores
        private void CargarAdministradores()
        {
            try
            {
                // Utiliza el método de la capa lógica para obtener la lista de administradores
                DataTable dt = _adminSeguridad.ObtenerAdministradores();
                dgvAdministradores.DataSource = dt;

                // Hacer visibles las columnas manualmente
                foreach (DataGridViewColumn column in dgvAdministradores.Columns)
                {
                    column.Visible = true;
                }

                // Ajustar el ancho de las columnas
                dgvAdministradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Asegurar que las columnas clave se muestran
                dgvAdministradores.Columns["IdSeguridad"].Visible = true;
                dgvAdministradores.Columns["StrClave"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar administradores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para agregar un nuevo administrador
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmCRUDAdminSeguridad crudForm = new frmCRUDAdminSeguridad())
            {
                crudForm.ShowDialog();
            }
            CargarAdministradores();
        }

        // Método para editar un administrador seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAdministradores.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvAdministradores.SelectedRows[0];
                string idSeguridad = filaSeleccionada.Cells["IdSeguridad"].Value?.ToString() ?? string.Empty;
                string idEmpleado = filaSeleccionada.Cells["IdEmpleado"].Value?.ToString() ?? string.Empty;
                string usuario = filaSeleccionada.Cells["StrUsuario"].Value?.ToString() ?? string.Empty;
                string usuarioModifico = filaSeleccionada.Cells["StrUsuarioModifico"].Value?.ToString() ?? string.Empty;
                DateTime fechaModifica = filaSeleccionada.Cells["DtmFechaModifica"].Value is DateTime fecha ? fecha : DateTime.Now;

                if (!string.IsNullOrEmpty(idSeguridad))
                {
                    using (frmCRUDAdminSeguridad crudForm = new frmCRUDAdminSeguridad(idSeguridad, idEmpleado, usuario, "", fechaModifica, usuarioModifico))
                    {
                        crudForm.ShowDialog();
                    }
                    CargarAdministradores();
                }
                else
                {
                    MessageBox.Show("El ID de seguridad no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un administrador para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para eliminar un administrador
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdministradores.SelectedRows.Count > 0)
            {
                string idSeguridadString = dgvAdministradores.SelectedRows[0].Cells["IdSeguridad"].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(idSeguridadString))
                {
                    // Intentar convertir el ID de seguridad a int
                    if (int.TryParse(idSeguridadString, out int idEmpleado))
                    {
                        // Confirmar la eliminación
                        DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este administrador?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            try
                            {
                                // Utilizar el método de la capa lógica para eliminar el administrador
                                int filasAfectadas = _adminSeguridad.EliminarAdministrador(idEmpleado);

                                // Verificar si se afectaron filas y mostrar mensaje correspondiente
                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Administrador eliminado con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el administrador para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                CargarAdministradores();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al eliminar administrador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID de seguridad no es válido. No se puede convertir a número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El ID de seguridad no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un administrador para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Método para salir del formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
