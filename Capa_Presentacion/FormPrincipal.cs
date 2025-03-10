using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//using Capa_Presentacion.Forms.Tablas;
//using Capa_Presentacion.Forms.Ayuda;
//using Capa_Presentacion.Forms.Facturacion;
using Capa_Presentacion.Menu.Seguridad;

namespace Capa_Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTablas_Click(object sender, EventArgs e)
        {
            SubmenuTablas.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SubmenuTablas.Visible = false;
            //frmListaClientes listaClientes = new frmListaClientes();
            //AbrirFormularioEnPanel(listaClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            SubmenuTablas.Visible = false;
            //frmListaProductos listaProductos = new frmListaProductos();
            //AbrirFormularioEnPanel(listaProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            SubmenuTablas.Visible = false;
            //frmListaCategoriaProductos listaCategorias = new frmListaCategoriaProductos();
            //AbrirFormularioEnPanel(listaCategorias);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            SubmenuFacturacion.Visible = true;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            SubmenuFacturacion.Visible = false;
            //frmListaFacturas listaFacturas = new frmListaFacturas();
            //AbrirFormularioEnPanel(listaFacturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            SubmenuFacturacion.Visible = false;
        }

        private void btnSegurida_Click(object sender, EventArgs e)
        {
            SubmenuSeguridad.Visible = true;
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            SubmenuSeguridad.Visible = false;
            frmListaAdminSeguridad adminSeguridad = new frmListaAdminSeguridad();
            AbrirFormularioEnPanel(adminSeguridad);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            SubmenuSeguridad.Visible = false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            SubmenuSeguridad.Visible = false;
            frmListaEmpleados listaEmpleados = new frmListaEmpleados();
            AbrirFormularioEnPanel(listaEmpleados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubmenuAyuda.Visible = true;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            SubmenuAyuda.Visible = false;
            //frmAyuda ayuda = new frmAyuda();
            //AbrirFormularioEnPanel(ayuda);
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            SubmenuAyuda.Visible = false;
            //frmAcercaDe acercaDe = new frmAcercaDe();
            //AbrirFormularioEnPanel(acercaDe);
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formulario);
            PanelContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
