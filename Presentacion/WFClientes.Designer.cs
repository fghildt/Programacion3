namespace Presentacion
{
    partial class WFClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarClie = new System.Windows.Forms.Button();
            this.btnEliminarClie = new System.Windows.Forms.Button();
            this.btnModificarClie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 35);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(502, 393);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnAgregarClie
            // 
            this.btnAgregarClie.Location = new System.Drawing.Point(106, 450);
            this.btnAgregarClie.Name = "btnAgregarClie";
            this.btnAgregarClie.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClie.TabIndex = 1;
            this.btnAgregarClie.Text = "Agregar";
            this.btnAgregarClie.UseVisualStyleBackColor = true;
            this.btnAgregarClie.Click += new System.EventHandler(this.btnAgregarClie_Click);
            // 
            // btnEliminarClie
            // 
            this.btnEliminarClie.Location = new System.Drawing.Point(346, 450);
            this.btnEliminarClie.Name = "btnEliminarClie";
            this.btnEliminarClie.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarClie.TabIndex = 2;
            this.btnEliminarClie.Text = "Eliminar";
            this.btnEliminarClie.UseVisualStyleBackColor = true;
            this.btnEliminarClie.Click += new System.EventHandler(this.btnEliminarClie_Click);
            // 
            // btnModificarClie
            // 
            this.btnModificarClie.Location = new System.Drawing.Point(226, 450);
            this.btnModificarClie.Name = "btnModificarClie";
            this.btnModificarClie.Size = new System.Drawing.Size(75, 23);
            this.btnModificarClie.TabIndex = 3;
            this.btnModificarClie.Text = "Modificar";
            this.btnModificarClie.UseVisualStyleBackColor = true;
            this.btnModificarClie.Click += new System.EventHandler(this.btnModificarClie_Click);
            // 
            // WFClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 490);
            this.Controls.Add(this.btnModificarClie);
            this.Controls.Add(this.btnEliminarClie);
            this.Controls.Add(this.btnAgregarClie);
            this.Controls.Add(this.dgvClientes);
            this.Name = "WFClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.WFClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregarClie;
        private System.Windows.Forms.Button btnEliminarClie;
        private System.Windows.Forms.Button btnModificarClie;
    }
}