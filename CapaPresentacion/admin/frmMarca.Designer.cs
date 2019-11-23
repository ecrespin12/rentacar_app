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
            this.txtMarcaId = new System.Windows.Forms.TextBox();
            this.cbestatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSearch_template.SuspendLayout();
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
            // btnNuevo_template
            // 
            this.btnNuevo_template.Click += new System.EventHandler(this.BtnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.label2);
            this.pnlModal.Controls.Add(this.label1);
            this.pnlModal.Controls.Add(this.cbestatus);
            this.pnlModal.Controls.Add(this.txtMarcaId);
            this.pnlModal.Controls.Add(this.txtNombre);
            this.pnlModal.Location = new System.Drawing.Point(222, 29);
            this.pnlModal.Size = new System.Drawing.Size(479, 435);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtMarcaId, 0);
            this.pnlModal.Controls.SetChildIndex(this.cbestatus, 0);
            this.pnlModal.Controls.SetChildIndex(this.label1, 0);
            this.pnlModal.Controls.SetChildIndex(this.label2, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(436, -1);
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 82);
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
            // txtMarcaId
            // 
            this.txtMarcaId.Location = new System.Drawing.Point(362, 397);
            this.txtMarcaId.Name = "txtMarcaId";
            this.txtMarcaId.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaId.TabIndex = 3;
            this.txtMarcaId.Visible = false;
            // 
            // cbestatus
            // 
            this.cbestatus.FormattingEnabled = true;
            this.cbestatus.Items.AddRange(new object[] {
            "ALTA",
            "BAJA"});
            this.cbestatus.Location = new System.Drawing.Point(35, 138);
            this.cbestatus.Name = "cbestatus";
            this.cbestatus.Size = new System.Drawing.Size(121, 21);
            this.cbestatus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 559);
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
        private System.Windows.Forms.TextBox txtMarcaId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbestatus;
    }
}