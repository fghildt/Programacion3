namespace Presentacion
{
    partial class WFProdXProv
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
            this.dgvProductosActivos = new System.Windows.Forms.DataGridView();
            this.TextProducto = new System.Windows.Forms.Label();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TextNombreProv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosActivos
            // 
            this.dgvProductosActivos.AllowUserToAddRows = false;
            this.dgvProductosActivos.AllowUserToDeleteRows = false;
            this.dgvProductosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosActivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductosActivos.Location = new System.Drawing.Point(12, 86);
            this.dgvProductosActivos.Name = "dgvProductosActivos";
            this.dgvProductosActivos.Size = new System.Drawing.Size(477, 231);
            this.dgvProductosActivos.TabIndex = 0;
            // 
            // TextProducto
            // 
            this.TextProducto.AutoSize = true;
            this.TextProducto.Location = new System.Drawing.Point(28, 41);
            this.TextProducto.Name = "TextProducto";
            this.TextProducto.Size = new System.Drawing.Size(53, 13);
            this.TextProducto.TabIndex = 1;
            this.TextProducto.Text = "Producto:";
            // 
            // CBProductos
            // 
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(98, 38);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(185, 21);
            this.CBProductos.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(332, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(200, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TextNombreProv
            // 
            this.TextNombreProv.AutoSize = true;
            this.TextNombreProv.Location = new System.Drawing.Point(22, 18);
            this.TextNombreProv.Name = "TextNombreProv";
            this.TextNombreProv.Size = new System.Drawing.Size(59, 13);
            this.TextNombreProv.TabIndex = 5;
            this.TextNombreProv.Text = "Proveedor:";
            // 
            // WFProdXProv
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.TextNombreProv);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.TextProducto);
            this.Controls.Add(this.dgvProductosActivos);
            this.Name = "WFProdXProv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar productos";
            this.Load += new System.EventHandler(this.WFProdXProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductosActivos;
        private System.Windows.Forms.Label TextProducto;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label TextNombreProv;
    }
}