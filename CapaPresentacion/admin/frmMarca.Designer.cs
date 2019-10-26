namespace CapaPresentacion.admin
{
    partial class frmMarca
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.epMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.prueba_editar = new System.Windows.Forms.Button();
            this.gbxSearch_template.SuspendLayout();
            this.pnlGrid_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch_template
            // 
            this.gbxSearch_template.Location = new System.Drawing.Point(9, 42);
            this.gbxSearch_template.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSearch_template.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSearch_template.Size = new System.Drawing.Size(606, 73);
            // 
            // txtSearch_template
            // 
            this.txtSearch_template.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch_template.Size = new System.Drawing.Size(432, 28);
            this.txtSearch_template.TextChanged += new System.EventHandler(this.TxtSearch_template_TextChanged);
            // 
            // lblTitle_template
            // 
            this.lblTitle_template.Location = new System.Drawing.Point(471, 7);
            this.lblTitle_template.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // pnlGrid_template
            // 
            //this.pnlGrid_template.Controls.Add(this.txtSearch_template);
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Click += new System.EventHandler(this.BtnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.txtNombre);
            this.pnlModal.Location = new System.Drawing.Point(222, 29);
            this.pnlModal.Size = new System.Drawing.Size(479, 435);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(294, -1);
            this.btnCloseModal.Click += new System.EventHandler(this.BtnCloseModal_Click);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Location = new System.Drawing.Point(113, 339);
            this.btnAccionModal.Click += new System.EventHandler(this.BtnAccionModal_Click);
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Location = new System.Drawing.Point(137, 7);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // epMarca
            // 
            this.epMarca.ContainerControl = this;
            // 
            // prueba_editar
            // 
            this.prueba_editar.Location = new System.Drawing.Point(735, 29);
            this.prueba_editar.Margin = new System.Windows.Forms.Padding(2);
            this.prueba_editar.Name = "prueba_editar";
            this.prueba_editar.Size = new System.Drawing.Size(56, 19);
            this.prueba_editar.TabIndex = 87;
            this.prueba_editar.Text = "prueba_editar";
            this.prueba_editar.UseVisualStyleBackColor = true;
            this.prueba_editar.Click += new System.EventHandler(this.Prueba_editar_Click);
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 559);
            this.Controls.Add(this.prueba_editar);
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.Controls.SetChildIndex(this.prueba_editar, 0);
            this.Controls.SetChildIndex(this.gbxSearch_template, 0);
            this.Controls.SetChildIndex(this.lblTitle_template, 0);
            this.Controls.SetChildIndex(this.pnlGrid_template, 0);
            this.Controls.SetChildIndex(this.pnlModal, 0);
            this.Controls.SetChildIndex(this.btnNuevo_template, 0);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlGrid_template.ResumeLayout(false);
            this.pnlGrid_template.PerformLayout();
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ErrorProvider epMarca;
        private System.Windows.Forms.Button prueba_editar;
    }
}