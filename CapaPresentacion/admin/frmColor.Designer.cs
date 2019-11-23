namespace CapaPresentacion.admin
{
    partial class frmColor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtCodColor = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxSearch_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch_template
            // 
            this.txtSearch_template.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch_template.Size = new System.Drawing.Size(418, 24);
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Click += new System.EventHandler(this.btnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.txtCodColor);
            this.pnlModal.Controls.Add(this.txtHex);
            this.pnlModal.Controls.Add(this.txtColor);
            this.pnlModal.Controls.Add(this.label2);
            this.pnlModal.Controls.Add(this.label1);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.label1, 0);
            this.pnlModal.Controls.SetChildIndex(this.label2, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtColor, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtHex, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtCodColor, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Click += new System.EventHandler(this.btnCloseModal_Click);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Click += new System.EventHandler(this.btnAccionModal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del  color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo hexadecimal";
            // 
            // txtColor
            // 
            this.txtColor.AccessibleName = "txtNombre";
            this.txtColor.Location = new System.Drawing.Point(135, 42);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 5;
            // 
            // txtHex
            // 
            this.txtHex.AccessibleName = "txtHexadecimal";
            this.txtHex.Location = new System.Drawing.Point(135, 83);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(100, 20);
            this.txtHex.TabIndex = 6;
            // 
            // txtCodColor
            // 
            this.txtCodColor.Location = new System.Drawing.Point(218, 318);
            this.txtCodColor.Name = "txtCodColor";
            this.txtCodColor.Size = new System.Drawing.Size(100, 20);
            this.txtCodColor.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 559);
            this.Name = "frmColor";
            this.Text = "frmColor2";
            this.Load += new System.EventHandler(this.FrmColor_Load);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodColor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}