namespace Presentacion
{
    partial class WFComprar
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.CBProveedor = new System.Windows.Forms.ComboBox();
            this.TextProveedor = new System.Windows.Forms.Label();
            this.TextProducto = new System.Windows.Forms.Label();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.TextStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TBCant = new System.Windows.Forms.TextBox();
            this.TBFactura = new System.Windows.Forms.TextBox();
            this.TextFactura = new System.Windows.Forms.Label();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TextPrecio = new System.Windows.Forms.Label();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.TBPrefijoFC = new System.Windows.Forms.TextBox();
            this.CBTipoFc = new System.Windows.Forms.ComboBox();
            this.DTPFechaFC = new System.Windows.Forms.DateTimePicker();
            this.TextFechaFC = new System.Windows.Forms.Label();
            this.TextAlerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.Location = new System.Drawing.Point(12, 161);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(442, 235);
            this.dgvCompras.TabIndex = 0;
            // 
            // CBProveedor
            // 
            this.CBProveedor.FormattingEnabled = true;
            this.CBProveedor.Location = new System.Drawing.Point(81, 12);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Size = new System.Drawing.Size(231, 21);
            this.CBProveedor.TabIndex = 1;
            this.CBProveedor.SelectedIndexChanged += new System.EventHandler(this.CBProveedor_SelectedIndexChanged);
            // 
            // TextProveedor
            // 
            this.TextProveedor.AutoSize = true;
            this.TextProveedor.Location = new System.Drawing.Point(16, 15);
            this.TextProveedor.Name = "TextProveedor";
            this.TextProveedor.Size = new System.Drawing.Size(59, 13);
            this.TextProveedor.TabIndex = 2;
            this.TextProveedor.Text = "Proveedor:";
            // 
            // TextProducto
            // 
            this.TextProducto.AutoSize = true;
            this.TextProducto.Location = new System.Drawing.Point(22, 43);
            this.TextProducto.Name = "TextProducto";
            this.TextProducto.Size = new System.Drawing.Size(53, 13);
            this.TextProducto.TabIndex = 3;
            this.TextProducto.Text = "Producto:";
            // 
            // CBProductos
            // 
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(81, 40);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(231, 21);
            this.CBProductos.TabIndex = 2;
            // 
            // TextStock
            // 
            this.TextStock.AutoSize = true;
            this.TextStock.Location = new System.Drawing.Point(78, 73);
            this.TextStock.Name = "TextStock";
            this.TextStock.Size = new System.Drawing.Size(52, 13);
            this.TextStock.TabIndex = 5;
            this.TextStock.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(346, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 60);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TBCant
            // 
            this.TBCant.Location = new System.Drawing.Point(136, 70);
            this.TBCant.Name = "TBCant";
            this.TBCant.Size = new System.Drawing.Size(36, 20);
            this.TBCant.TabIndex = 3;
            this.TBCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCant_KeyPress);
            // 
            // TBFactura
            // 
            this.TBFactura.Location = new System.Drawing.Point(222, 96);
            this.TBFactura.MaxLength = 8;
            this.TBFactura.Name = "TBFactura";
            this.TBFactura.Size = new System.Drawing.Size(74, 20);
            this.TBFactura.TabIndex = 7;
            this.TBFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBFactura_KeyPress);
            // 
            // TextFactura
            // 
            this.TextFactura.AutoSize = true;
            this.TextFactura.Location = new System.Drawing.Point(78, 99);
            this.TextFactura.Name = "TextFactura";
            this.TextFactura.Size = new System.Drawing.Size(46, 13);
            this.TextFactura.TabIndex = 9;
            this.TextFactura.Text = "Factura:";
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Location = new System.Drawing.Point(182, 413);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(94, 29);
            this.btnAgregarCompra.TabIndex = 10;
            this.btnAgregarCompra.Text = "Agregar compra";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(260, 70);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(36, 20);
            this.TBPrecio.TabIndex = 4;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecio_KeyPress);
            // 
            // TextPrecio
            // 
            this.TextPrecio.AutoSize = true;
            this.TextPrecio.Location = new System.Drawing.Point(202, 73);
            this.TextPrecio.Name = "TextPrecio";
            this.TextPrecio.Size = new System.Drawing.Size(40, 13);
            this.TextPrecio.TabIndex = 11;
            this.TextPrecio.Text = "Precio:";
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.Location = new System.Drawing.Point(474, 232);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(46, 35);
            this.BTNEliminar.TabIndex = 13;
            this.BTNEliminar.Text = "-";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // TBPrefijoFC
            // 
            this.TBPrefijoFC.Location = new System.Drawing.Point(136, 95);
            this.TBPrefijoFC.MaxLength = 4;
            this.TBPrefijoFC.Name = "TBPrefijoFC";
            this.TBPrefijoFC.Size = new System.Drawing.Size(42, 20);
            this.TBPrefijoFC.TabIndex = 5;
            this.TBPrefijoFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrefijoFC_KeyPress);
            // 
            // CBTipoFc
            // 
            this.CBTipoFc.FormattingEnabled = true;
            this.CBTipoFc.Location = new System.Drawing.Point(184, 95);
            this.CBTipoFc.Name = "CBTipoFc";
            this.CBTipoFc.Size = new System.Drawing.Size(32, 21);
            this.CBTipoFc.TabIndex = 6;
            // 
            // DTPFechaFC
            // 
            this.DTPFechaFC.Location = new System.Drawing.Point(136, 122);
            this.DTPFechaFC.Name = "DTPFechaFC";
            this.DTPFechaFC.Size = new System.Drawing.Size(160, 20);
            this.DTPFechaFC.TabIndex = 14;
            // 
            // TextFechaFC
            // 
            this.TextFechaFC.AutoSize = true;
            this.TextFechaFC.Location = new System.Drawing.Point(48, 128);
            this.TextFechaFC.Name = "TextFechaFC";
            this.TextFechaFC.Size = new System.Drawing.Size(76, 13);
            this.TextFechaFC.TabIndex = 15;
            this.TextFechaFC.Text = "Fecha factura:";
            // 
            // TextAlerta
            // 
            this.TextAlerta.AutoEllipsis = true;
            this.TextAlerta.AutoSize = true;
            this.TextAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAlerta.ForeColor = System.Drawing.Color.Red;
            this.TextAlerta.Location = new System.Drawing.Point(302, 125);
            this.TextAlerta.Name = "TextAlerta";
            this.TextAlerta.Size = new System.Drawing.Size(0, 16);
            this.TextAlerta.TabIndex = 16;
            // 
            // WFComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 457);
            this.Controls.Add(this.TextAlerta);
            this.Controls.Add(this.TextFechaFC);
            this.Controls.Add(this.DTPFechaFC);
            this.Controls.Add(this.CBTipoFc);
            this.Controls.Add(this.TBPrefijoFC);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TextPrecio);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.TextFactura);
            this.Controls.Add(this.TBFactura);
            this.Controls.Add(this.TBCant);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.TextStock);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.TextProducto);
            this.Controls.Add(this.TextProveedor);
            this.Controls.Add(this.CBProveedor);
            this.Controls.Add(this.dgvCompras);
            this.Name = "WFComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.WFComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.ComboBox CBProveedor;
        private System.Windows.Forms.Label TextProveedor;
        private System.Windows.Forms.Label TextProducto;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Label TextStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox TBCant;
        private System.Windows.Forms.TextBox TBFactura;
        private System.Windows.Forms.Label TextFactura;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label TextPrecio;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.TextBox TBPrefijoFC;
        private System.Windows.Forms.ComboBox CBTipoFc;
        private System.Windows.Forms.DateTimePicker DTPFechaFC;
        private System.Windows.Forms.Label TextFechaFC;
        private System.Windows.Forms.Label TextAlerta;
    }
}