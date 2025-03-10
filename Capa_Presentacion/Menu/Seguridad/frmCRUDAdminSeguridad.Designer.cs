namespace Capa_Presentacion.Menu.Seguridad
{
    partial class frmCRUDAdminSeguridad
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.DateTimePicker dtpFechaModifica;
        private System.Windows.Forms.TextBox txtUsuarioModifico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblFechaModifica;
        private System.Windows.Forms.Label lblUsuarioModifico;

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
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.dtpFechaModifica = new System.Windows.Forms.DateTimePicker();
            this.txtUsuarioModifico = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblFechaModifica = new System.Windows.Forms.Label();
            this.lblUsuarioModifico = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblIdEmpleado
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(20, 20);
            this.lblIdEmpleado.Text = "ID Empleado:";

            // txtIdEmpleado
            this.txtIdEmpleado.Location = new System.Drawing.Point(150, 20);
            this.txtIdEmpleado.Size = new System.Drawing.Size(200, 20);

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 60);
            this.lblUsuario.Text = "Usuario:";

            // txtUsuario
            this.txtUsuario.Location = new System.Drawing.Point(150, 60);
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);

            // lblClave
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(20, 100);
            this.lblClave.Text = "Clave:";

            // txtClave
            this.txtClave.Location = new System.Drawing.Point(150, 100);
            this.txtClave.Size = new System.Drawing.Size(200, 20);
            this.txtClave.PasswordChar = '*';

            // lblFechaModifica
            this.lblFechaModifica.AutoSize = true;
            this.lblFechaModifica.Location = new System.Drawing.Point(20, 140);
            this.lblFechaModifica.Text = "Fecha Modificación:";

            // dtpFechaModifica
            this.dtpFechaModifica.Location = new System.Drawing.Point(150, 140);
            this.dtpFechaModifica.Size = new System.Drawing.Size(200, 20);

            // lblUsuarioModifico
            this.lblUsuarioModifico.AutoSize = true;
            this.lblUsuarioModifico.Location = new System.Drawing.Point(20, 180);
            this.lblUsuarioModifico.Text = "Usuario Modificó:";

            // txtUsuarioModifico
            this.txtUsuarioModifico.Location = new System.Drawing.Point(150, 180);
            this.txtUsuarioModifico.Size = new System.Drawing.Size(200, 20);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(50, 240);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(200, 240);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // frmCRUDAdminSeguridad
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblFechaModifica);
            this.Controls.Add(this.dtpFechaModifica);
            this.Controls.Add(this.lblUsuarioModifico);
            this.Controls.Add(this.txtUsuarioModifico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}