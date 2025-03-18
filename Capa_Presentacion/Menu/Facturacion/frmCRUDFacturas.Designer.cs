using System.Drawing;
using System.Windows.Forms;

namespace Capa_Presentacion.Menu.Facturacion
{
    partial class frmCRUDFacturas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpDatosFactura = new GroupBox();
            txtNumeroFactura = new TextBox();
            txtCliente = new ComboBox();
            txtEmpleado = new TextBox();
            txtDescuento = new TextBox();
            txtTotalIVA = new TextBox();
            txtTotalFactura = new TextBox();
            txtFechaRegistro = new DateTimePicker();
            cmbEstadoFactura = new ComboBox();
            lblNumeroFactura = new Label();
            lblCliente = new Label();
            lblEmpleado = new Label();
            lblDescuento = new Label();
            lblTotalIVA = new Label();
            lblTotalFactura = new Label();
            lblFechaRegistro = new Label();
            lblEstadoFactura = new Label();
            btnActualizar = new Button();
            btnSalir = new Button();
            grpDetalleFactura = new GroupBox();
            dgvDetalleFactura = new DataGridView();
            grpDatosFactura.SuspendLayout();
            grpDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(180, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(299, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // grpDatosFactura
            // 
            grpDatosFactura.Controls.Add(txtNumeroFactura);
            grpDatosFactura.Controls.Add(txtCliente);
            grpDatosFactura.Controls.Add(txtEmpleado);
            grpDatosFactura.Controls.Add(txtDescuento);
            grpDatosFactura.Controls.Add(txtTotalIVA);
            grpDatosFactura.Controls.Add(txtTotalFactura);
            grpDatosFactura.Controls.Add(txtFechaRegistro);
            grpDatosFactura.Controls.Add(cmbEstadoFactura);
            grpDatosFactura.Controls.Add(lblNumeroFactura);
            grpDatosFactura.Controls.Add(lblCliente);
            grpDatosFactura.Controls.Add(lblEmpleado);
            grpDatosFactura.Controls.Add(lblDescuento);
            grpDatosFactura.Controls.Add(lblTotalIVA);
            grpDatosFactura.Controls.Add(lblTotalFactura);
            grpDatosFactura.Controls.Add(lblFechaRegistro);
            grpDatosFactura.Controls.Add(lblEstadoFactura);
            grpDatosFactura.Location = new Point(20, 40);
            grpDatosFactura.Name = "grpDatosFactura";
            grpDatosFactura.Size = new Size(400, 274);
            grpDatosFactura.TabIndex = 1;
            grpDatosFactura.TabStop = false;
            grpDatosFactura.Text = "Datos de la Factura";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(150, 30);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(100, 23);
            txtNumeroFactura.TabIndex = 0;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(150, 60);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(121, 23);
            txtCliente.TabIndex = 1;
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(150, 90);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(100, 23);
            txtEmpleado.TabIndex = 2;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(150, 120);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            // 
            // txtTotalIVA
            // 
            txtTotalIVA.Location = new Point(150, 150);
            txtTotalIVA.Name = "txtTotalIVA";
            txtTotalIVA.Size = new Size(100, 23);
            txtTotalIVA.TabIndex = 4;
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(150, 180);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(100, 23);
            txtTotalFactura.TabIndex = 5;
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Location = new Point(150, 210);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.Size = new Size(200, 23);
            txtFechaRegistro.TabIndex = 6;
            // 
            // cmbEstadoFactura
            // 
            cmbEstadoFactura.Location = new Point(150, 240);
            cmbEstadoFactura.Name = "cmbEstadoFactura";
            cmbEstadoFactura.Size = new Size(121, 23);
            cmbEstadoFactura.TabIndex = 7;
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.Location = new Point(20, 30);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(100, 23);
            lblNumeroFactura.TabIndex = 8;
            lblNumeroFactura.Text = "Número Factura:";
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(20, 60);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(100, 23);
            lblCliente.TabIndex = 9;
            lblCliente.Text = "Cliente:";
            // 
            // lblEmpleado
            // 
            lblEmpleado.Location = new Point(20, 90);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(100, 23);
            lblEmpleado.TabIndex = 10;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(20, 120);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(100, 23);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTotalIVA
            // 
            lblTotalIVA.Location = new Point(20, 150);
            lblTotalIVA.Name = "lblTotalIVA";
            lblTotalIVA.Size = new Size(100, 23);
            lblTotalIVA.TabIndex = 12;
            lblTotalIVA.Text = "Total IVA:";
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.Location = new Point(20, 180);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(100, 23);
            lblTotalFactura.TabIndex = 13;
            lblTotalFactura.Text = "Total Factura:";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.Location = new Point(20, 210);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(100, 23);
            lblFechaRegistro.TabIndex = 14;
            lblFechaRegistro.Text = "Fecha Registro:";
            // 
            // lblEstadoFactura
            // 
            lblEstadoFactura.Location = new Point(20, 240);
            lblEstadoFactura.Name = "lblEstadoFactura";
            lblEstadoFactura.Size = new Size(100, 23);
            lblEstadoFactura.TabIndex = 15;
            lblEstadoFactura.Text = "Estado Factura:";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(50, 320);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(150, 320);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            // 
            // grpDetalleFactura
            // 
            grpDetalleFactura.Controls.Add(dgvDetalleFactura);
            grpDetalleFactura.Location = new Point(20, 350);
            grpDetalleFactura.Name = "grpDetalleFactura";
            grpDetalleFactura.Size = new Size(400, 200);
            grpDetalleFactura.TabIndex = 2;
            grpDetalleFactura.TabStop = false;
            grpDetalleFactura.Text = "Detalle de la Factura";
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.Location = new Point(10, 20);
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.Size = new Size(380, 160);
            dgvDetalleFactura.TabIndex = 0;
            // 
            // frmCRUDFacturas
            // 
            ClientSize = new Size(450, 580);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosFactura);
            Controls.Add(grpDetalleFactura);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Name = "frmCRUDFacturas";
            Text = "Gestión de Facturas";
            grpDatosFactura.ResumeLayout(false);
            grpDatosFactura.PerformLayout();
            grpDetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatosFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalIVA;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.DateTimePicker txtFechaRegistro;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.Label lblNumeroFactura, lblCliente, lblEmpleado, lblDescuento, lblTotalIVA, lblTotalFactura, lblFechaRegistro, lblEstadoFactura;
        private System.Windows.Forms.Button btnActualizar, btnSalir;
        private System.Windows.Forms.GroupBox grpDetalleFactura;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
    }
}