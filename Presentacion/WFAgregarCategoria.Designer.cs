namespace Presentacion
{
    partial class WFAgregarCategoria
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
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.LBNombreCategoria = new System.Windows.Forms.Label();
            this.TBCategoriaNueva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(195, 120);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 5;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(51, 120);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 4;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // LBNombreCategoria
            // 
            this.LBNombreCategoria.AutoSize = true;
            this.LBNombreCategoria.Location = new System.Drawing.Point(29, 29);
            this.LBNombreCategoria.Name = "LBNombreCategoria";
            this.LBNombreCategoria.Size = new System.Drawing.Size(122, 13);
            this.LBNombreCategoria.TabIndex = 7;
            this.LBNombreCategoria.Text = "Nombre de la categoría:";
            // 
            // TBCategoriaNueva
            // 
            this.TBCategoriaNueva.Location = new System.Drawing.Point(32, 55);
            this.TBCategoriaNueva.Name = "TBCategoriaNueva";
            this.TBCategoriaNueva.Size = new System.Drawing.Size(214, 20);
            this.TBCategoriaNueva.TabIndex = 6;
            // 
            // WFAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 168);
            this.Controls.Add(this.LBNombreCategoria);
            this.Controls.Add(this.TBCategoriaNueva);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Name = "WFAgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Label LBNombreCategoria;
        private System.Windows.Forms.TextBox TBCategoriaNueva;
    }
}