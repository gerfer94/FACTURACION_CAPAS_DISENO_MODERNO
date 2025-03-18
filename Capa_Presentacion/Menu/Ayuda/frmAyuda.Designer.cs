using System.Drawing;
using System.Windows.Forms;

namespace Capa_Presentacion.Menu.Ayuda
{
    partial class frmAyuda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos en uso.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para el soporte del Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            webBrowser1 = new WebBrowser();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // webBrowser1
            // 
            webBrowser1.Dock = DockStyle.Top;
            webBrowser1.Location = new Point(0, 0);
            webBrowser1.MinimumSize = new Size(18, 19);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(700, 422);
            webBrowser1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom;
            btnCerrar.Location = new Point(306, 431);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(88, 28);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmAyuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 469);
            Controls.Add(btnCerrar);
            Controls.Add(webBrowser1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAyuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayuda";
            Load += frmAyuda_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnCerrar;
    }
}