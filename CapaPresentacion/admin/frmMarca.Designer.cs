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
            this.gbxSearch_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch_template
            // 
            this.gbxSearch_template.Size = new System.Drawing.Size(808, 90);
            // 
            // txtSearch_template
            // 
            this.txtSearch_template.Size = new System.Drawing.Size(764, 34);
            // 
            // lblTitle_template
            // 
            this.lblTitle_template.Location = new System.Drawing.Point(628, 9);
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Click += new System.EventHandler(this.BtnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.txtNombre);
            this.pnlModal.Location = new System.Drawing.Point(258, 71);
            this.pnlModal.Size = new System.Drawing.Size(638, 535);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(581, -1);
            this.btnCloseModal.Click += new System.EventHandler(this.BtnCloseModal_Click);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Location = new System.Drawing.Point(245, 483);
            this.btnAccionModal.Click += new System.EventHandler(this.BtnAccionModal_Click);
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Location = new System.Drawing.Point(277, 9);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // epMarca
            // 
            this.epMarca.ContainerControl = this;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 688);
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ErrorProvider epMarca;
    }
}