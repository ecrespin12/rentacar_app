namespace CapaPresentacion.admin
{
    partial class frmAuto
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.epErrorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxSearch_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch_template
            // 
            this.txtSearch_template.TextChanged += new System.EventHandler(this.TxtSearch_template_TextChanged);
            // 
            // lblTitle_template
            // 
            this.lblTitle_template.Location = new System.Drawing.Point(1, 1);
            this.lblTitle_template.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle_template.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Location = new System.Drawing.Point(750, 77);
            this.btnNuevo_template.Click += new System.EventHandler(this.BtnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.comboBox1);
            this.pnlModal.Controls.Add(this.textBox2);
            this.pnlModal.Controls.Add(this.label2);
            this.pnlModal.Controls.Add(this.label1);
            this.pnlModal.Controls.Add(this.textBox1);
            this.pnlModal.Controls.Add(this.txtCodigo);
            this.pnlModal.Controls.Add(this.lblEstado);
            this.pnlModal.Controls.Add(this.txtEstado);
            this.pnlModal.Location = new System.Drawing.Point(194, 58);
            this.pnlModal.Size = new System.Drawing.Size(479, 435);
            this.pnlModal.Controls.SetChildIndex(this.txtEstado, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblEstado, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.textBox1, 0);
            this.pnlModal.Controls.SetChildIndex(this.label1, 0);
            this.pnlModal.Controls.SetChildIndex(this.label2, 0);
            this.pnlModal.Controls.SetChildIndex(this.textBox2, 0);
            this.pnlModal.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(433, 2);
            this.btnCloseModal.Click += new System.EventHandler(this.BtnCloseModal_Click);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Location = new System.Drawing.Point(184, 392);
            this.btnAccionModal.Click += new System.EventHandler(this.BtnAccionModal_Click);
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Location = new System.Drawing.Point(1, 1);
            this.lblTituloModal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTituloModal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEstado
            // 
            this.txtEstado.AccessibleName = "txtMarca";
            this.txtEstado.Location = new System.Drawing.Point(146, 33);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 3;
            this.txtEstado.TextChanged += new System.EventHandler(this.TxtEstado_TextChanged);
            // 
            // epErrorEstado
            // 
            this.epErrorEstado.ContainerControl = this;
            // 
            // lblEstado
            // 
            this.lblEstado.AccessibleName = "";
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(42, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Marca";
            this.lblEstado.Click += new System.EventHandler(this.LblEstado_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(362, 397);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Visible = false;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "txtColor";
            this.textBox1.Location = new System.Drawing.Point(146, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de auto";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "txtTipo";
            this.textBox2.Location = new System.Drawing.Point(146, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 559);
            this.Name = "frmAuto";
            this.Text = "frmAuto";
            this.Load += new System.EventHandler(this.FrmAuto_Load);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ErrorProvider epErrorEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}