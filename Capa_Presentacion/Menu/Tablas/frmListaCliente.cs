using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Capa_Presentacion.Menu.Tablas
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarClientes();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.Columns.Clear();

            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdCliente", HeaderText = "ID", DataPropertyName = "IdCliente" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Documento", HeaderText = "Documento", DataPropertyName = "Documento" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Direccion", HeaderText = "Dirección", DataPropertyName = "Direccion" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Telefono", HeaderText = "Teléfono", DataPropertyName = "Telefono" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaModifica", HeaderText = "Última Modificación", DataPropertyName = "FechaModifica" });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "UsuarioModifica", HeaderText = "Usuario Modificación", DataPropertyName = "UsuarioModifica" });

            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CargarClientes()
        {
            try
            {
                Cls_Cliente cliente = new Cls_Cliente();
                List<Cls_Cliente> listaClientes = cliente.ObtenerTodosLosClientes(); // Método agregado en Cls_Cliente

                dataGridViewClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCRUDCliente agregar = new frmCRUDCliente();
            agregar.ShowDialog();
            CargarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["IdCliente"].Value);
                frmCRUDCliente editar = new frmCRUDCliente(idCliente);
                editar.ShowDialog();
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridViewClientes.SelectedRows[0].Cells["IdCliente"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Cls_Cliente cliente = new Cls_Cliente();
                        cliente.EliminarCliente(idCliente); // Método agregado en Cls_Cliente

                        CargarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
