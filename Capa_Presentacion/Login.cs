using Capa_Presentacion;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;
using System.Drawing;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text.Trim();
            string contraseña = txtpass.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debes ingresar un usuario y una clave", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto de la clase Validar_usuario
            Validar_Usuario obj_validar = new Validar_Usuario();
            obj_validar.Usuario = usuario;
            obj_validar.Clave = contraseña;
            bool esValido = obj_validar.ValidarUsuario();
            if (esValido)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPrincipal formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtuser.Focus();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "User")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "User";
                txtuser.ForeColor = Color.Gray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }
    }
}
