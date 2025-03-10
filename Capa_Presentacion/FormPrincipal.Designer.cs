using System.Drawing;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            BarraTitulo = new Panel();
            panel8 = new Panel();
            sistema = new Label();
            button2 = new Button();
            btnPrincipal = new Button();
            btnSegurida = new Button();
            btnTablas = new Button();
            btnFacturacion = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            btnSalir = new PictureBox();
            pictureBox1 = new PictureBox();
            PanelContenedor = new Panel();
            SubmenuAyuda = new Panel();
            btnAcercade = new Button();
            btnAyuda = new Button();
            SubmenuSeguridad = new Panel();
            btnEmpleados = new Button();
            btnRoles = new Button();
            btnSeguridad = new Button();
            SubmenuFacturacion = new Panel();
            btnInformes = new Button();
            btnFacturas = new Button();
            SubmenuTablas = new Panel();
            btnCategorias = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            BarraTitulo.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelContenedor.SuspendLayout();
            SubmenuAyuda.SuspendLayout();
            SubmenuSeguridad.SuspendLayout();
            SubmenuFacturacion.SuspendLayout();
            SubmenuTablas.SuspendLayout();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(panel8);
            BarraTitulo.Controls.Add(panel6);
            BarraTitulo.Controls.Add(panel5);
            BarraTitulo.Controls.Add(panel4);
            BarraTitulo.Controls.Add(panel3);
            BarraTitulo.Controls.Add(panel2);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 88);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(sistema);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(btnPrincipal);
            panel8.Controls.Add(btnSegurida);
            panel8.Controls.Add(btnTablas);
            panel8.Controls.Add(btnFacturacion);
            panel8.Location = new Point(0, 41);
            panel8.Name = "panel8";
            panel8.Size = new Size(1303, 47);
            panel8.TabIndex = 3;
            // 
            // sistema
            // 
            sistema.AutoSize = true;
            sistema.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sistema.ForeColor = Color.White;
            sistema.Location = new Point(128, 14);
            sistema.Name = "sistema";
            sistema.Size = new Size(274, 24);
            sistema.TabIndex = 4;
            sistema.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1095, 3);
            button2.Name = "button2";
            button2.Size = new Size(113, 35);
            button2.TabIndex = 6;
            button2.Text = "Ayuda";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnPrincipal
            // 
            btnPrincipal.FlatAppearance.BorderSize = 0;
            btnPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnPrincipal.FlatStyle = FlatStyle.Flat;
            btnPrincipal.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrincipal.ForeColor = Color.White;
            btnPrincipal.Location = new Point(555, 2);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(113, 35);
            btnPrincipal.TabIndex = 1;
            btnPrincipal.Text = "Principal";
            btnPrincipal.UseVisualStyleBackColor = true;
            btnPrincipal.Click += btnPrincipal_Click;
            // 
            // btnSegurida
            // 
            btnSegurida.FlatAppearance.BorderSize = 0;
            btnSegurida.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnSegurida.FlatStyle = FlatStyle.Flat;
            btnSegurida.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSegurida.ForeColor = Color.White;
            btnSegurida.Location = new Point(966, 2);
            btnSegurida.Name = "btnSegurida";
            btnSegurida.Size = new Size(113, 35);
            btnSegurida.TabIndex = 6;
            btnSegurida.Text = "Seguridad";
            btnSegurida.UseVisualStyleBackColor = true;
            btnSegurida.Click += btnSegurida_Click;
            // 
            // btnTablas
            // 
            btnTablas.FlatAppearance.BorderSize = 0;
            btnTablas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnTablas.FlatStyle = FlatStyle.Flat;
            btnTablas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTablas.ForeColor = Color.White;
            btnTablas.Location = new Point(689, 3);
            btnTablas.Name = "btnTablas";
            btnTablas.Size = new Size(113, 35);
            btnTablas.TabIndex = 5;
            btnTablas.Text = "Tablas";
            btnTablas.UseVisualStyleBackColor = true;
            btnTablas.Click += btnTablas_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Location = new Point(820, 2);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(113, 35);
            btnFacturacion.TabIndex = 5;
            btnFacturacion.Text = "Facturación";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(26, 32, 40);
            panel6.Location = new Point(1095, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(113, 11);
            panel6.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(26, 32, 40);
            panel5.Location = new Point(966, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(113, 11);
            panel5.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.Location = new Point(820, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(113, 11);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Location = new Point(689, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 11);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Location = new Point(555, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(113, 11);
            panel2.TabIndex = 4;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1241, 7);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1210, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1241, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1272, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnClose_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(btnSalir);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 88);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 562);
            MenuVertical.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(73, 384);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 63);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 1;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Controls.Add(SubmenuAyuda);
            PanelContenedor.Controls.Add(SubmenuSeguridad);
            PanelContenedor.Controls.Add(SubmenuFacturacion);
            PanelContenedor.Controls.Add(SubmenuTablas);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(220, 88);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1080, 562);
            PanelContenedor.TabIndex = 2;
            // 
            // SubmenuAyuda
            // 
            SubmenuAyuda.Controls.Add(btnAcercade);
            SubmenuAyuda.Controls.Add(btnAyuda);
            SubmenuAyuda.Location = new Point(875, 3);
            SubmenuAyuda.Name = "SubmenuAyuda";
            SubmenuAyuda.Size = new Size(113, 81);
            SubmenuAyuda.TabIndex = 8;
            SubmenuAyuda.Visible = false;
            // 
            // btnAcercade
            // 
            btnAcercade.FlatAppearance.BorderSize = 0;
            btnAcercade.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnAcercade.FlatStyle = FlatStyle.Flat;
            btnAcercade.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcercade.ForeColor = Color.White;
            btnAcercade.Location = new Point(7, 44);
            btnAcercade.Name = "btnAcercade";
            btnAcercade.Size = new Size(100, 35);
            btnAcercade.TabIndex = 4;
            btnAcercade.Text = "Acerca de";
            btnAcercade.UseVisualStyleBackColor = true;
            btnAcercade.Click += btnAcercade_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = Color.White;
            btnAyuda.Location = new Point(7, 3);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(100, 35);
            btnAyuda.TabIndex = 3;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // SubmenuSeguridad
            // 
            SubmenuSeguridad.Controls.Add(btnEmpleados);
            SubmenuSeguridad.Controls.Add(btnRoles);
            SubmenuSeguridad.Controls.Add(btnSeguridad);
            SubmenuSeguridad.Location = new Point(746, 3);
            SubmenuSeguridad.Name = "SubmenuSeguridad";
            SubmenuSeguridad.Size = new Size(113, 123);
            SubmenuSeguridad.TabIndex = 7;
            SubmenuSeguridad.Visible = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(7, 85);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(100, 35);
            btnEmpleados.TabIndex = 5;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = Color.White;
            btnRoles.Location = new Point(7, 44);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(100, 35);
            btnRoles.TabIndex = 4;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnSeguridad
            // 
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeguridad.ForeColor = Color.White;
            btnSeguridad.Location = new Point(3, 3);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Size = new Size(100, 35);
            btnSeguridad.TabIndex = 3;
            btnSeguridad.Text = "Seguridad";
            btnSeguridad.UseVisualStyleBackColor = true;
            btnSeguridad.Click += btnSeguridad_Click;
            // 
            // SubmenuFacturacion
            // 
            SubmenuFacturacion.Controls.Add(btnInformes);
            SubmenuFacturacion.Controls.Add(btnFacturas);
            SubmenuFacturacion.Location = new Point(600, 3);
            SubmenuFacturacion.Name = "SubmenuFacturacion";
            SubmenuFacturacion.Size = new Size(113, 81);
            SubmenuFacturacion.TabIndex = 6;
            SubmenuFacturacion.Visible = false;
            // 
            // btnInformes
            // 
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInformes.ForeColor = Color.White;
            btnInformes.Location = new Point(7, 44);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(100, 35);
            btnInformes.TabIndex = 4;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturas.ForeColor = Color.White;
            btnFacturas.Location = new Point(7, 3);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(100, 35);
            btnFacturas.TabIndex = 3;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // SubmenuTablas
            // 
            SubmenuTablas.Controls.Add(btnCategorias);
            SubmenuTablas.Controls.Add(btnProductos);
            SubmenuTablas.Controls.Add(btnClientes);
            SubmenuTablas.Location = new Point(469, 3);
            SubmenuTablas.Name = "SubmenuTablas";
            SubmenuTablas.Size = new Size(113, 123);
            SubmenuTablas.TabIndex = 5;
            SubmenuTablas.Visible = false;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(7, 85);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(100, 35);
            btnCategorias.TabIndex = 5;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(7, 46);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(100, 35);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(7, 5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(100, 35);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PanelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelContenedor.ResumeLayout(false);
            SubmenuAyuda.ResumeLayout(false);
            SubmenuSeguridad.ResumeLayout(false);
            SubmenuFacturacion.ResumeLayout(false);
            SubmenuTablas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel PanelContenedor;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private PictureBox pictureBox1;
        private Button btnPrincipal;
        private Label sistema;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button btnTablas;
        private Button btnFacturacion;
        private Panel panel6;
        private Panel panel5;
        private Button button2;
        private Button btnSegurida;
        private PictureBox btnSalir;
        private Panel SubmenuTablas;
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnClientes;
        private Panel SubmenuSeguridad;
        private Button btnEmpleados;
        private Button btnRoles;
        private Button btnSeguridad;
        private Panel SubmenuFacturacion;
        private Button btnInformes;
        private Button btnFacturas;
        private Panel SubmenuAyuda;
        private Button btnAcercade;
        private Button btnAyuda;
        private Panel panel8;
    }
}
