using System.Drawing;
using System.Windows.Forms;

namespace Capa_Presentacion.Menu.Tablas
{
    partial class frmCRUDProductos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarProducto; // Nuevo botón agregado
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtRutaFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnCargarImagen;

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
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            cmbCategoria = new ComboBox();
            txtDetalles = new TextBox();
            btnActualizar = new Button();
            btnSalir = new Button();
            btnAgregarProducto = new Button();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblPrecioCompra = new Label();
            lblPrecioVenta = new Label();
            lblStock = new Label();
            lblCategoria = new Label();
            lblDetalles = new Label();
            txtRutaFoto = new TextBox();
            pbFoto = new PictureBox();
            btnCargarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(120, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(231, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Administración de Productos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(150, 90);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(150, 130);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 3;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(150, 170);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(150, 210);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Location = new Point(150, 250);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // txtDetalles
            // 
            txtDetalles.Location = new Point(150, 290);
            txtDetalles.Multiline = true;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.Size = new Size(200, 60);
            txtDetalles.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(130, 400);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(220, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(130, 444);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(120, 30);
            btnAgregarProducto.TabIndex = 10;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new Point(20, 90);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 23);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Código:";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.Location = new Point(20, 130);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(100, 23);
            lblPrecioCompra.TabIndex = 13;
            lblPrecioCompra.Text = "Precio Compra:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.Location = new Point(20, 170);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(100, 23);
            lblPrecioVenta.TabIndex = 14;
            lblPrecioVenta.Text = "Precio Venta:";
            // 
            // lblStock
            // 
            lblStock.Location = new Point(20, 210);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 23);
            lblStock.TabIndex = 15;
            lblStock.Text = "Stock:";
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(20, 250);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 23);
            lblCategoria.TabIndex = 16;
            lblCategoria.Text = "Categoría:";
            // 
            // lblDetalles
            // 
            lblDetalles.Location = new Point(20, 290);
            lblDetalles.Name = "lblDetalles";
            lblDetalles.Size = new Size(100, 23);
            lblDetalles.TabIndex = 17;
            lblDetalles.Text = "Detalles:";
            // 
            // txtRutaFoto
            // 
            txtRutaFoto.Location = new Point(20, 360);
            txtRutaFoto.Name = "txtRutaFoto";
            txtRutaFoto.Size = new Size(230, 23);
            txtRutaFoto.TabIndex = 18;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(20, 390);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(100, 100);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 20;
            pbFoto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(260, 360);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(75, 23);
            btnCargarImagen.TabIndex = 19;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // frmCRUDProductos
            // 
            ClientSize = new Size(400, 520);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtStock);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDetalles);
            Controls.Add(btnActualizar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregarProducto);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(lblPrecioCompra);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblStock);
            Controls.Add(lblCategoria);
            Controls.Add(lblDetalles);
            Controls.Add(txtRutaFoto);
            Controls.Add(btnCargarImagen);
            Controls.Add(pbFoto);
            Name = "frmCRUDProductos";
            Text = "CRUD Productos";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}