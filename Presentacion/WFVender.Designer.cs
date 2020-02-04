namespace Presentacion
{
    partial class WFVender
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
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.TBCant = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TextStock = new System.Windows.Forms.Label();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.TextProducto = new System.Windows.Forms.Label();
            this.TextCliente = new System.Windows.Forms.Label();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.TextAlertaCant = new System.Windows.Forms.Label();
            this.CBTipoFc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(478, 240);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(46, 35);
            this.BTNEliminar.TabIndex = 27;
            this.BTNEliminar.Text = "-";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(186, 390);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarVenta.TabIndex = 24;
            this.btnAgregarVenta.Text = "Agregar venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // TBCant
            // 
            this.TBCant.Location = new System.Drawing.Point(186, 75);
            this.TBCant.MaxLength = 4;
            this.TBCant.Name = "TBCant";
            this.TBCant.Size = new System.Drawing.Size(36, 20);
            this.TBCant.TabIndex = 21;
            this.TBCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCant_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(348, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 60);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TextStock
            // 
            this.TextStock.AutoSize = true;
            this.TextStock.Location = new System.Drawing.Point(128, 78);
            this.TextStock.Name = "TextStock";
            this.TextStock.Size = new System.Drawing.Size(52, 13);
            this.TextStock.TabIndex = 19;
            this.TextStock.Text = "Cantidad:";
            // 
            // CBProductos
            // 
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(85, 48);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(231, 21);
            this.CBProductos.TabIndex = 18;
            // 
            // TextProducto
            // 
            this.TextProducto.AutoSize = true;
            this.TextProducto.Location = new System.Drawing.Point(26, 51);
            this.TextProducto.Name = "TextProducto";
            this.TextProducto.Size = new System.Drawing.Size(53, 13);
            this.TextProducto.TabIndex = 17;
            this.TextProducto.Text = "Producto:";
            // 
            // TextCliente
            // 
            this.TextCliente.AutoSize = true;
            this.TextCliente.Location = new System.Drawing.Point(37, 23);
            this.TextCliente.Name = "TextCliente";
            this.TextCliente.Size = new System.Drawing.Size(42, 13);
            this.TextCliente.TabIndex = 16;
            this.TextCliente.Text = "Cliente:";
            // 
            // CBCliente
            // 
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Location = new System.Drawing.Point(85, 20);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(231, 21);
            this.CBCliente.TabIndex = 15;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentas.Location = new System.Drawing.Point(16, 104);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(442, 269);
            this.dgvVentas.TabIndex = 14;
            // 
            // TextAlertaCant
            // 
            this.TextAlertaCant.AutoSize = true;
            this.TextAlertaCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAlertaCant.ForeColor = System.Drawing.Color.Red;
            this.TextAlertaCant.Location = new System.Drawing.Point(228, 78);
            this.TextAlertaCant.Name = "TextAlertaCant";
            this.TextAlertaCant.Size = new System.Drawing.Size(0, 16);
            this.TextAlertaCant.TabIndex = 28;
            // 
            // CBTipoFc
            // 
            this.CBTipoFc.FormattingEnabled = true;
            this.CBTipoFc.Location = new System.Drawing.Point(114, 395);
            this.CBTipoFc.Name = "CBTipoFc";
            this.CBTipoFc.Size = new System.Drawing.Size(38, 21);
            this.CBTipoFc.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tipo de factura:";
            // 
            // WFVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBTipoFc);
            this.Controls.Add(this.TextAlertaCant);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.TBCant);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.TextStock);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.TextProducto);
            this.Controls.Add(this.TextCliente);
            this.Controls.Add(this.CBCliente);
            this.Controls.Add(this.dgvVentas);
            this.Name = "WFVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.WFVender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.TextBox TBCant;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label TextStock;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Label TextProducto;
        private System.Windows.Forms.Label TextCliente;
        private System.Windows.Forms.ComboBox CBCliente;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label TextAlertaCant;
        private System.Windows.Forms.ComboBox CBTipoFc;
        private System.Windows.Forms.Label label1;
    }
}