namespace CapaPresentacion.admin
{
    partial class frmTipoAuto
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
            this.txtNombreTipoAuto = new System.Windows.Forms.TextBox();
            this.epErrorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbxSearch_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch_template
            // 
            this.txtSearch_template.TextChanged += new System.EventHandler(this.TxtSearch_template_TextChanged);
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Location = new System.Drawing.Point(750, 77);
            this.btnNuevo_template.Click += new System.EventHandler(this.BtnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.txtCodigo);
            this.pnlModal.Controls.Add(this.lblNombre);
            this.pnlModal.Controls.Add(this.txtNombreTipoAuto);
            this.pnlModal.Location = new System.Drawing.Point(222, 29);
            this.pnlModal.Size = new System.Drawing.Size(479, 435);
            this.pnlModal.Controls.SetChildIndex(this.txtNombreTipoAuto, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblNombre, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(433, 2);
            this.btnCloseModal.Click += new System.EventHandler(this.BtnCloseModal_Click);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Location = new System.Drawing.Point(35, 180);
            this.btnAccionModal.Click += new System.EventHandler(this.BtnAccionModal_Click);
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Location = new System.Drawing.Point(137, 7);
            // 
            // txtNombreTipoAuto
            // 
            this.txtNombreTipoAuto.AccessibleName = "txtNombreTipoAuto";
            this.txtNombreTipoAuto.Location = new System.Drawing.Point(21, 72);
            this.txtNombreTipoAuto.Name = "txtNombreTipoAuto";
            this.txtNombreTipoAuto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTipoAuto.TabIndex = 3;
            // 
            // epErrorNombre
            // 
            this.epErrorNombre.ContainerControl = this;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre de Tipo de Auto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(362, 397);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Visible = false;
            // 
            // frmTipoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 559);
            this.Name = "frmTipoAuto";
            this.Text = "frmTipoAuto";
            this.Load += new System.EventHandler(this.FrmTipoAuto_Load);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTipoAuto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider epErrorNombre;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}