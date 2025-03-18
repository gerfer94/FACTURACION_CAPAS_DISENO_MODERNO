namespace Capa_Presentacion.Menu.Tablas
{
    partial class frmListaCategoriaProductos
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dgvCategorias;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Button btnAgregarEditar;

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
        this.dgvCategorias = new System.Windows.Forms.DataGridView();
        this.btnSalir = new System.Windows.Forms.Button();
        this.btnAgregarEditar = new System.Windows.Forms.Button();

        ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
        this.SuspendLayout();

        // 
        // dgvCategorias
        // 
        this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvCategorias.Location = new System.Drawing.Point(12, 12);
        this.dgvCategorias.Name = "dgvCategorias";
        this.dgvCategorias.Size = new System.Drawing.Size(360, 200);
        this.dgvCategorias.TabIndex = 0;

        // 
        // btnSalir
        // 
        this.btnSalir.Location = new System.Drawing.Point(300, 230);
        this.btnSalir.Name = "btnSalir";
        this.btnSalir.Size = new System.Drawing.Size(75, 23);
        this.btnSalir.TabIndex = 1;
        this.btnSalir.Text = "Salir";
        this.btnSalir.UseVisualStyleBackColor = true;
        this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

        // 
        // btnAgregarEditar
        // 
        this.btnAgregarEditar.Location = new System.Drawing.Point(200, 230);
        this.btnAgregarEditar.Name = "btnAgregarEditar";
        this.btnAgregarEditar.Size = new System.Drawing.Size(95, 23);
        this.btnAgregarEditar.TabIndex = 2;
        this.btnAgregarEditar.Text = "Agregar/Editar";
        this.btnAgregarEditar.UseVisualStyleBackColor = true;
        this.btnAgregarEditar.Click += new System.EventHandler(this.btnAgregarEditar_Click);

        // 
        // frmListaCategoriaProductos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 270);
        this.Controls.Add(this.btnAgregarEditar);
        this.Controls.Add(this.btnSalir);
        this.Controls.Add(this.dgvCategorias);
        this.Name = "frmListaCategoriaProductos";
        this.Text = "Lista de Categorías de Productos";
        ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
        this.ResumeLayout(false);
    }
}
}

