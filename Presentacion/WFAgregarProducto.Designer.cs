namespace Presentacion
{
    partial class WFAgregarProducto
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
            this.LBNombreProd = new System.Windows.Forms.Label();
            this.LBPrecCompProd = new System.Windows.Forms.Label();
            this.LBGanancia = new System.Windows.Forms.Label();
            this.LBMarca = new System.Windows.Forms.Label();
            this.LBCategoria = new System.Windows.Forms.Label();
            this.LBPorcentaje = new System.Windows.Forms.Label();
            this.TBNombreProd = new System.Windows.Forms.TextBox();
            this.TBPorcentajeGanProd = new System.Windows.Forms.TextBox();
            this.TBPrecCompraProd = new System.Windows.Forms.TextBox();
            this.CBMarcaProd = new System.Windows.Forms.ComboBox();
            this.CBCategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBNombreProd
            // 
            this.LBNombreProd.AutoSize = true;
            this.LBNombreProd.Location = new System.Drawing.Point(95, 29);
            this.LBNombreProd.Name = "LBNombreProd";
            this.LBNombreProd.Size = new System.Drawing.Size(44, 13);
            this.LBNombreProd.TabIndex = 0;
            this.LBNombreProd.Text = "Nombre";
            // 
            // LBPrecCompProd
            // 
            this.LBPrecCompProd.AutoSize = true;
            this.LBPrecCompProd.Location = new System.Drawing.Point(49, 71);
            this.LBPrecCompProd.Name = "LBPrecCompProd";
            this.LBPrecCompProd.Size = new System.Drawing.Size(90, 13);
            this.LBPrecCompProd.TabIndex = 1;
            this.LBPrecCompProd.Text = "Precio de compra";
            // 
            // LBGanancia
            // 
            this.LBGanancia.AutoSize = true;
            this.LBGanancia.Location = new System.Drawing.Point(19, 110);
            this.LBGanancia.Name = "LBGanancia";
            this.LBGanancia.Size = new System.Drawing.Size(120, 13);
            this.LBGanancia.TabIndex = 2;
            this.LBGanancia.Text = "Porcentaje de ganancia";
            // 
            // LBMarca
            // 
            this.LBMarca.AutoSize = true;
            this.LBMarca.Location = new System.Drawing.Point(102, 155);
            this.LBMarca.Name = "LBMarca";
            this.LBMarca.Size = new System.Drawing.Size(37, 13);
            this.LBMarca.TabIndex = 3;
            this.LBMarca.Text = "Marca";
            // 
            // LBCategoria
            // 
            this.LBCategoria.AutoSize = true;
            this.LBCategoria.Location = new System.Drawing.Point(85, 197);
            this.LBCategoria.Name = "LBCategoria";
            this.LBCategoria.Size = new System.Drawing.Size(54, 13);
            this.LBCategoria.TabIndex = 4;
            this.LBCategoria.Text = "Categoría";
            // 
            // LBPorcentaje
            // 
            this.LBPorcentaje.AutoSize = true;
            this.LBPorcentaje.Location = new System.Drawing.Point(298, 110);
            this.LBPorcentaje.Name = "LBPorcentaje";
            this.LBPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.LBPorcentaje.TabIndex = 5;
            this.LBPorcentaje.Text = "%";
            // 
            // TBNombreProd
            // 
            this.TBNombreProd.Location = new System.Drawing.Point(151, 26);
            this.TBNombreProd.Name = "TBNombreProd";
            this.TBNombreProd.Size = new System.Drawing.Size(141, 20);
            this.TBNombreProd.TabIndex = 6;
            // 
            // TBPorcentajeGanProd
            // 
            this.TBPorcentajeGanProd.Location = new System.Drawing.Point(151, 107);
            this.TBPorcentajeGanProd.Name = "TBPorcentajeGanProd";
            this.TBPorcentajeGanProd.Size = new System.Drawing.Size(141, 20);
            this.TBPorcentajeGanProd.TabIndex = 7;
            // 
            // TBPrecCompraProd
            // 
            this.TBPrecCompraProd.Location = new System.Drawing.Point(151, 68);
            this.TBPrecCompraProd.Name = "TBPrecCompraProd";
            this.TBPrecCompraProd.Size = new System.Drawing.Size(141, 20);
            this.TBPrecCompraProd.TabIndex = 8;
            // 
            // CBMarcaProd
            // 
            this.CBMarcaProd.FormattingEnabled = true;
            this.CBMarcaProd.Location = new System.Drawing.Point(151, 152);
            this.CBMarcaProd.Name = "CBMarcaProd";
            this.CBMarcaProd.Size = new System.Drawing.Size(162, 21);
            this.CBMarcaProd.TabIndex = 9;
            // 
            // CBCategoriaProd
            // 
            this.CBCategoriaProd.FormattingEnabled = true;
            this.CBCategoriaProd.Location = new System.Drawing.Point(151, 194);
            this.CBCategoriaProd.Name = "CBCategoriaProd";
            this.CBCategoriaProd.Size = new System.Drawing.Size(162, 21);
            this.CBCategoriaProd.TabIndex = 10;
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Location = new System.Drawing.Point(217, 255);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCliente.TabIndex = 12;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(71, 255);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 11;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // WFAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 300);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.CBCategoriaProd);
            this.Controls.Add(this.CBMarcaProd);
            this.Controls.Add(this.TBPrecCompraProd);
            this.Controls.Add(this.TBPorcentajeGanProd);
            this.Controls.Add(this.TBNombreProd);
            this.Controls.Add(this.LBPorcentaje);
            this.Controls.Add(this.LBCategoria);
            this.Controls.Add(this.LBMarca);
            this.Controls.Add(this.LBGanancia);
            this.Controls.Add(this.LBPrecCompProd);
            this.Controls.Add(this.LBNombreProd);
            this.Name = "WFAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto";
            this.Load += new System.EventHandler(this.WFAgregarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBNombreProd;
        private System.Windows.Forms.Label LBPrecCompProd;
        private System.Windows.Forms.Label LBGanancia;
        private System.Windows.Forms.Label LBMarca;
        private System.Windows.Forms.Label LBCategoria;
        private System.Windows.Forms.Label LBPorcentaje;
        private System.Windows.Forms.TextBox TBNombreProd;
        private System.Windows.Forms.TextBox TBPorcentajeGanProd;
        private System.Windows.Forms.TextBox TBPrecCompraProd;
        private System.Windows.Forms.ComboBox CBMarcaProd;
        private System.Windows.Forms.ComboBox CBCategoriaProd;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}