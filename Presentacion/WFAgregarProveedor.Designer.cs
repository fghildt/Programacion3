namespace Presentacion
{
    partial class WFAgregarProveedor
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
            this.btnCancelarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.TBNombreProv = new System.Windows.Forms.TextBox();
            this.TBMailPRov = new System.Windows.Forms.TextBox();
            this.TBDireccProv = new System.Windows.Forms.TextBox();
            this.TBTelefProv = new System.Windows.Forms.TextBox();
            this.TBCuitProv = new System.Windows.Forms.TextBox();
            this.LBNombreProveedor = new System.Windows.Forms.Label();
            this.LBCuit = new System.Windows.Forms.Label();
            this.LBMail = new System.Windows.Forms.Label();
            this.LBDireccion = new System.Windows.Forms.Label();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.btnProdXProv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.Location = new System.Drawing.Point(196, 313);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProveedor.TabIndex = 7;
            this.btnCancelarProveedor.Text = "Cancelar";
            this.btnCancelarProveedor.UseVisualStyleBackColor = true;
            this.btnCancelarProveedor.Click += new System.EventHandler(this.btnCancelarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(50, 313);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProveedor.TabIndex = 6;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // TBNombreProv
            // 
            this.TBNombreProv.Location = new System.Drawing.Point(118, 28);
            this.TBNombreProv.Name = "TBNombreProv";
            this.TBNombreProv.Size = new System.Drawing.Size(100, 20);
            this.TBNombreProv.TabIndex = 1;
            // 
            // TBMailPRov
            // 
            this.TBMailPRov.Location = new System.Drawing.Point(118, 205);
            this.TBMailPRov.Name = "TBMailPRov";
            this.TBMailPRov.Size = new System.Drawing.Size(100, 20);
            this.TBMailPRov.TabIndex = 5;
            // 
            // TBDireccProv
            // 
            this.TBDireccProv.Location = new System.Drawing.Point(118, 160);
            this.TBDireccProv.Name = "TBDireccProv";
            this.TBDireccProv.Size = new System.Drawing.Size(100, 20);
            this.TBDireccProv.TabIndex = 4;
            // 
            // TBTelefProv
            // 
            this.TBTelefProv.Location = new System.Drawing.Point(118, 116);
            this.TBTelefProv.Name = "TBTelefProv";
            this.TBTelefProv.Size = new System.Drawing.Size(100, 20);
            this.TBTelefProv.TabIndex = 3;
            // 
            // TBCuitProv
            // 
            this.TBCuitProv.Location = new System.Drawing.Point(118, 72);
            this.TBCuitProv.Name = "TBCuitProv";
            this.TBCuitProv.Size = new System.Drawing.Size(100, 20);
            this.TBCuitProv.TabIndex = 2;
            // 
            // LBNombreProveedor
            // 
            this.LBNombreProveedor.AutoSize = true;
            this.LBNombreProveedor.Location = new System.Drawing.Point(13, 31);
            this.LBNombreProveedor.Name = "LBNombreProveedor";
            this.LBNombreProveedor.Size = new System.Drawing.Size(98, 13);
            this.LBNombreProveedor.TabIndex = 8;
            this.LBNombreProveedor.Text = "Nombre proveedor:";
            // 
            // LBCuit
            // 
            this.LBCuit.AutoSize = true;
            this.LBCuit.Location = new System.Drawing.Point(76, 75);
            this.LBCuit.Name = "LBCuit";
            this.LBCuit.Size = new System.Drawing.Size(35, 13);
            this.LBCuit.TabIndex = 9;
            this.LBCuit.Text = "CUIT:";
            // 
            // LBMail
            // 
            this.LBMail.AutoSize = true;
            this.LBMail.Location = new System.Drawing.Point(15, 208);
            this.LBMail.Name = "LBMail";
            this.LBMail.Size = new System.Drawing.Size(96, 13);
            this.LBMail.TabIndex = 12;
            this.LBMail.Text = "Correo electrónico:";
            // 
            // LBDireccion
            // 
            this.LBDireccion.AutoSize = true;
            this.LBDireccion.Location = new System.Drawing.Point(56, 163);
            this.LBDireccion.Name = "LBDireccion";
            this.LBDireccion.Size = new System.Drawing.Size(55, 13);
            this.LBDireccion.TabIndex = 11;
            this.LBDireccion.Text = "Dirección:";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Location = new System.Drawing.Point(59, 119);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(52, 13);
            this.LBTelefono.TabIndex = 10;
            this.LBTelefono.Text = "Telefono:";
            // 
            // btnProdXProv
            // 
            this.btnProdXProv.Enabled = false;
            this.btnProdXProv.Location = new System.Drawing.Point(85, 251);
            this.btnProdXProv.Name = "btnProdXProv";
            this.btnProdXProv.Size = new System.Drawing.Size(150, 39);
            this.btnProdXProv.TabIndex = 13;
            this.btnProdXProv.Text = "Modificar productos de este proveedor";
            this.btnProdXProv.UseVisualStyleBackColor = true;
            this.btnProdXProv.Click += new System.EventHandler(this.btnProdXProv_Click);
            // 
            // WFAgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 361);
            this.Controls.Add(this.btnProdXProv);
            this.Controls.Add(this.LBTelefono);
            this.Controls.Add(this.LBDireccion);
            this.Controls.Add(this.LBMail);
            this.Controls.Add(this.LBCuit);
            this.Controls.Add(this.LBNombreProveedor);
            this.Controls.Add(this.TBCuitProv);
            this.Controls.Add(this.TBTelefProv);
            this.Controls.Add(this.TBDireccProv);
            this.Controls.Add(this.TBMailPRov);
            this.Controls.Add(this.TBNombreProv);
            this.Controls.Add(this.btnCancelarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Name = "WFAgregarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.TextBox TBNombreProv;
        private System.Windows.Forms.TextBox TBMailPRov;
        private System.Windows.Forms.TextBox TBDireccProv;
        private System.Windows.Forms.TextBox TBTelefProv;
        private System.Windows.Forms.TextBox TBCuitProv;
        private System.Windows.Forms.Label LBNombreProveedor;
        private System.Windows.Forms.Label LBCuit;
        private System.Windows.Forms.Label LBMail;
        private System.Windows.Forms.Label LBDireccion;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.Button btnProdXProv;
    }
}