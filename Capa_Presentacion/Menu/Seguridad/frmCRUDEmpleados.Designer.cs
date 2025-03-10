namespace Capa_Presentacion.Menu.Seguridad
{
    partial class frmCRUDEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRolEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRolEmpleado;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.Label lblDatosAdicionales;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbRolEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaRetiro = new System.Windows.Forms.Label();
            this.lblDatosAdicionales = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // Configuración de etiquetas
            this.lblNombre.Text = "Nombre Empleado:";
            this.lblDocumento.Text = "Documento:";
            this.lblDireccion.Text = "Dirección:";
            this.lblTelefono.Text = "Teléfono:";
            this.lblEmail.Text = "Email:";
            this.lblRolEmpleado.Text = "Rol Empleado:";
            this.lblFechaIngreso.Text = "F. Ingreso:";
            this.lblFechaRetiro.Text = "F. Retiro:";
            this.lblDatosAdicionales.Text = "Datos Adicionales:";

            // Posicionamiento de etiquetas y campos de entrada
            this.lblNombre.SetBounds(20, 20, 120, 20);
            this.txtNombre.SetBounds(150, 20, 200, 20);

            this.lblDocumento.SetBounds(20, 50, 120, 20);
            this.txtDocumento.SetBounds(150, 50, 200, 20);

            this.lblDireccion.SetBounds(20, 80, 120, 20);
            this.txtDireccion.SetBounds(150, 80, 200, 20);

            this.lblTelefono.SetBounds(20, 110, 120, 20);
            this.txtTelefono.SetBounds(150, 110, 200, 20);

            this.lblEmail.SetBounds(20, 140, 120, 20);
            this.txtEmail.SetBounds(150, 140, 200, 20);

            this.lblRolEmpleado.SetBounds(400, 20, 100, 20);
            this.cmbRolEmpleado.SetBounds(510, 20, 200, 20);

            this.lblFechaIngreso.SetBounds(400, 50, 100, 20);
            this.dtpFechaIngreso.SetBounds(510, 50, 200, 20);

            this.lblFechaRetiro.SetBounds(400, 80, 100, 20);
            this.dtpFechaRetiro.SetBounds(510, 80, 200, 20);
            this.chkActivo.SetBounds(720, 80, 70, 20);
            this.chkActivo.Text = "Activo";

            this.lblDatosAdicionales.SetBounds(20, 170, 150, 20);
            this.txtDatosAdicionales.SetBounds(20, 200, 690, 80);
            this.txtDatosAdicionales.Multiline = true;

            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.SetBounds(400, 300, 100, 30);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnSalir.Text = "Salir";
            this.btnSalir.SetBounds(520, 300, 100, 30);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Agregar controles al formulario
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRolEmpleado);
            this.Controls.Add(this.cmbRolEmpleado);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaRetiro);
            this.Controls.Add(this.dtpFechaRetiro);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblDatosAdicionales);
            this.Controls.Add(this.txtDatosAdicionales);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);

            // Configuración del formulario
            this.Text = "Administración de Empleados";
            this.ClientSize = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}