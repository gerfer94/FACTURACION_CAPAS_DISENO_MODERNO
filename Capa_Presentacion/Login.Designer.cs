using System.Drawing.Printing;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Capa_Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label2 = new Label();
            btnlogin = new Button();
            linkpass = new LinkLabel();
            btnclose = new PictureBox();
            btnminimize = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnminimize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 381);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(61, 104);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(194, 162);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.White;
            txtuser.Location = new Point(346, 104);
            txtuser.Margin = new Padding(4, 3, 4, 3);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(477, 20);
            txtuser.TabIndex = 1;
            txtuser.Text = "User";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.White;
            txtpass.Location = new Point(346, 187);
            txtpass.Margin = new Padding(4, 3, 4, 3);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(477, 20);
            txtpass.TabIndex = 2;
            txtpass.Text = "Password";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(593, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 33);
            label2.TabIndex = 5;
            label2.Text = "LOGIN";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.LightGray;
            btnlogin.Location = new Point(346, 231);
            btnlogin.Margin = new Padding(4, 3, 4, 3);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(477, 46);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "ACCEDER";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkpass.LinkColor = Color.DimGray;
            linkpass.Location = new Point(491, 291);
            linkpass.Margin = new Padding(4, 0, 4, 0);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(176, 20);
            linkpass.TabIndex = 0;
            linkpass.TabStop = true;
            linkpass.Text = "Recuperar Contraseña";
            // 
            // btnclose
            // 
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.Location = new Point(889, 3);
            btnclose.Margin = new Padding(4, 3, 4, 3);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(18, 17);
            btnclose.SizeMode = PictureBoxSizeMode.Zoom;
            btnclose.TabIndex = 8;
            btnclose.TabStop = false;
            btnclose.Click += btnclose_Click;
            // 
            // btnminimize
            // 
            btnminimize.Image = (Image)resources.GetObject("btnminimize.Image");
            btnminimize.Location = new Point(864, 3);
            btnminimize.Margin = new Padding(4, 3, 4, 3);
            btnminimize.Name = "btnminimize";
            btnminimize.Size = new Size(18, 17);
            btnminimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnminimize.TabIndex = 9;
            btnminimize.TabStop = false;
            btnminimize.Click += btnminimize_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(910, 381);
            Controls.Add(btnminimize);
            Controls.Add(btnclose);
            Controls.Add(linkpass);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            MouseDown += LoginForm_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnclose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnminimize).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnminimize;
    }
}