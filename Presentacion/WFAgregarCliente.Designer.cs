namespace Presentacion
{
    partial class WFAgregarCliente
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
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.LBDireccion = new System.Windows.Forms.Label();
            this.LBMail = new System.Windows.Forms.Label();
            this.LBCuit = new System.Windows.Forms.Label();
            this.LBNombreProveedor = new System.Windows.Forms.Label();
            this.TBCuitClie = new System.Windows.Forms.TextBox();
            this.TBTelefClie = new System.Windows.Forms.TextBox();
            this.TBDireccClie = new System.Windows.Forms.TextBox();
            this.TBMailClie = new System.Windows.Forms.TextBox();
            this.TBNombreClie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPFnac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Location = new System.Drawing.Point(198, 270);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCliente.TabIndex = 7;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(52, 270);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Location = new System.Drawing.Point(69, 103);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(49, 13);
            this.LBTelefono.TabIndex = 25;
            this.LBTelefono.Text = "Telefono";
            // 
            // LBDireccion
            // 
            this.LBDireccion.AutoSize = true;
            this.LBDireccion.Location = new System.Drawing.Point(66, 147);
            this.LBDireccion.Name = "LBDireccion";
            this.LBDireccion.Size = new System.Drawing.Size(52, 13);
            this.LBDireccion.TabIndex = 24;
            this.LBDireccion.Text = "Direccion";
            // 
            // LBMail
            // 
            this.LBMail.AutoSize = true;
            this.LBMail.Location = new System.Drawing.Point(25, 192);
            this.LBMail.Name = "LBMail";
            this.LBMail.Size = new System.Drawing.Size(93, 13);
            this.LBMail.TabIndex = 23;
            this.LBMail.Text = "Correo electrónico";
            // 
            // LBCuit
            // 
            this.LBCuit.AutoSize = true;
            this.LBCuit.Location = new System.Drawing.Point(86, 59);
            this.LBCuit.Name = "LBCuit";
            this.LBCuit.Size = new System.Drawing.Size(32, 13);
            this.LBCuit.TabIndex = 22;
            this.LBCuit.Text = "CUIT";
            // 
            // LBNombreProveedor
            // 
            this.LBNombreProveedor.AutoSize = true;
            this.LBNombreProveedor.Location = new System.Drawing.Point(27, 15);
            this.LBNombreProveedor.Name = "LBNombreProveedor";
            this.LBNombreProveedor.Size = new System.Drawing.Size(91, 13);
            this.LBNombreProveedor.TabIndex = 21;
            this.LBNombreProveedor.Text = "Nombre y apellido";
            // 
            // TBCuitClie
            // 
            this.TBCuitClie.Location = new System.Drawing.Point(128, 56);
            this.TBCuitClie.Name = "TBCuitClie";
            this.TBCuitClie.Size = new System.Drawing.Size(200, 20);
            this.TBCuitClie.TabIndex = 20;
            // 
            // TBTelefClie
            // 
            this.TBTelefClie.Location = new System.Drawing.Point(128, 100);
            this.TBTelefClie.Name = "TBTelefClie";
            this.TBTelefClie.Size = new System.Drawing.Size(200, 20);
            this.TBTelefClie.TabIndex = 19;
            // 
            // TBDireccClie
            // 
            this.TBDireccClie.Location = new System.Drawing.Point(128, 144);
            this.TBDireccClie.Name = "TBDireccClie";
            this.TBDireccClie.Size = new System.Drawing.Size(200, 20);
            this.TBDireccClie.TabIndex = 18;
            // 
            // TBMailClie
            // 
            this.TBMailClie.Location = new System.Drawing.Point(128, 189);
            this.TBMailClie.Name = "TBMailClie";
            this.TBMailClie.Size = new System.Drawing.Size(200, 20);
            this.TBMailClie.TabIndex = 17;
            // 
            // TBNombreClie
            // 
            this.TBNombreClie.Location = new System.Drawing.Point(128, 12);
            this.TBNombreClie.Name = "TBNombreClie";
            this.TBNombreClie.Size = new System.Drawing.Size(200, 20);
            this.TBNombreClie.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // DTPFnac
            // 
            this.DTPFnac.Location = new System.Drawing.Point(128, 231);
            this.DTPFnac.Name = "DTPFnac";
            this.DTPFnac.Size = new System.Drawing.Size(200, 20);
            this.DTPFnac.TabIndex = 27;
            // 
            // WFAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 305);
            this.Controls.Add(this.DTPFnac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBTelefono);
            this.Controls.Add(this.LBDireccion);
            this.Controls.Add(this.LBMail);
            this.Controls.Add(this.LBCuit);
            this.Controls.Add(this.LBNombreProveedor);
            this.Controls.Add(this.TBCuitClie);
            this.Controls.Add(this.TBTelefClie);
            this.Controls.Add(this.TBDireccClie);
            this.Controls.Add(this.TBMailClie);
            this.Controls.Add(this.TBNombreClie);
            this.Controls.Add(this.btnCancelarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Name = "WFAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.Label LBDireccion;
        private System.Windows.Forms.Label LBMail;
        private System.Windows.Forms.Label LBCuit;
        private System.Windows.Forms.Label LBNombreProveedor;
        private System.Windows.Forms.TextBox TBCuitClie;
        private System.Windows.Forms.TextBox TBTelefClie;
        private System.Windows.Forms.TextBox TBDireccClie;
        private System.Windows.Forms.TextBox TBMailClie;
        private System.Windows.Forms.TextBox TBNombreClie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPFnac;
    }
}