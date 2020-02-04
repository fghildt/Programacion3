namespace Presentacion
{
    partial class WFProveedores
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnModificarClie = new System.Windows.Forms.Button();
            this.btnEliminarClie = new System.Windows.Forms.Button();
            this.btnAgregarClie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 35);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(507, 393);
            this.dgvProveedores.TabIndex = 0;
            // 
            // btnModificarClie
            // 
            this.btnModificarClie.Location = new System.Drawing.Point(228, 445);
            this.btnModificarClie.Name = "btnModificarClie";
            this.btnModificarClie.Size = new System.Drawing.Size(75, 23);
            this.btnModificarClie.TabIndex = 6;
            this.btnModificarClie.Text = "Modificar";
            this.btnModificarClie.UseVisualStyleBackColor = true;
            this.btnModificarClie.Click += new System.EventHandler(this.btnModificarClie_Click);
            // 
            // btnEliminarClie
            // 
            this.btnEliminarClie.Location = new System.Drawing.Point(348, 445);
            this.btnEliminarClie.Name = "btnEliminarClie";
            this.btnEliminarClie.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarClie.TabIndex = 5;
            this.btnEliminarClie.Text = "Eliminar";
            this.btnEliminarClie.UseVisualStyleBackColor = true;
            this.btnEliminarClie.Click += new System.EventHandler(this.btnEliminarClie_Click);
            // 
            // btnAgregarClie
            // 
            this.btnAgregarClie.Location = new System.Drawing.Point(108, 445);
            this.btnAgregarClie.Name = "btnAgregarClie";
            this.btnAgregarClie.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClie.TabIndex = 4;
            this.btnAgregarClie.Text = "Agregar";
            this.btnAgregarClie.UseVisualStyleBackColor = true;
            this.btnAgregarClie.Click += new System.EventHandler(this.btnAgregarClie_Click);
            // 
            // WFProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 490);
            this.Controls.Add(this.btnModificarClie);
            this.Controls.Add(this.btnEliminarClie);
            this.Controls.Add(this.btnAgregarClie);
            this.Controls.Add(this.dgvProveedores);
            this.Name = "WFProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.WFProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnModificarClie;
        private System.Windows.Forms.Button btnEliminarClie;
        private System.Windows.Forms.Button btnAgregarClie;
    }
}