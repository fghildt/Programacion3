namespace Presentacion
{
    partial class WFProductos
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
            this.btnModificarClie = new System.Windows.Forms.Button();
            this.btnEliminarClie = new System.Windows.Forms.Button();
            this.btnAgregarClie = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarClie
            // 
            this.btnModificarClie.Location = new System.Drawing.Point(226, 455);
            this.btnModificarClie.Name = "btnModificarClie";
            this.btnModificarClie.Size = new System.Drawing.Size(75, 23);
            this.btnModificarClie.TabIndex = 9;
            this.btnModificarClie.Text = "Modificar";
            this.btnModificarClie.UseVisualStyleBackColor = true;
            this.btnModificarClie.Click += new System.EventHandler(this.btnModificarClie_Click);
            // 
            // btnEliminarClie
            // 
            this.btnEliminarClie.Location = new System.Drawing.Point(346, 455);
            this.btnEliminarClie.Name = "btnEliminarClie";
            this.btnEliminarClie.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarClie.TabIndex = 8;
            this.btnEliminarClie.Text = "Eliminar";
            this.btnEliminarClie.UseVisualStyleBackColor = true;
            this.btnEliminarClie.Click += new System.EventHandler(this.btnEliminarClie_Click);
            // 
            // btnAgregarClie
            // 
            this.btnAgregarClie.Location = new System.Drawing.Point(106, 455);
            this.btnAgregarClie.Name = "btnAgregarClie";
            this.btnAgregarClie.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarClie.TabIndex = 7;
            this.btnAgregarClie.Text = "Agregar";
            this.btnAgregarClie.UseVisualStyleBackColor = true;
            this.btnAgregarClie.Click += new System.EventHandler(this.btnAgregarClie_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 35);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(502, 393);
            this.dgvProductos.TabIndex = 10;
            // 
            // WFProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 490);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnModificarClie);
            this.Controls.Add(this.btnEliminarClie);
            this.Controls.Add(this.btnAgregarClie);
            this.Name = "WFProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.WFProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificarClie;
        private System.Windows.Forms.Button btnEliminarClie;
        private System.Windows.Forms.Button btnAgregarClie;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}