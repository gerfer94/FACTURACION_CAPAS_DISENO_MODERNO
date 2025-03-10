using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Seguridad
{
    public partial class frmListaEmpleados : Form
    {
        private Cls_Empleados empleados = new Cls_Empleados();

        public frmListaEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            DataTable dt = empleados.Filtrar_Empleado("");
            if (dt != null)
            {
                dgvEmpleados.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar los empleados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCRUDEmpleados frm = new frmCRUDEmpleados(); // Suponiendo que hay un formulario para agregar empleados
            frm.ShowDialog();
            CargarEmpleados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value);

                frmCRUDEmpleados frm = new frmCRUDEmpleados(idEmpleado); // Pasamos solo el ID
                frm.ShowDialog();
                CargarEmpleados(); // Recargar la lista después de editar
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                empleados.C_IdEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["IdEmpleado"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string mensaje = empleados.EliminaEmpleado();
                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
