namespace CapaPresentacion.caja
{
    partial class frmCajaPagos
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbxSearch_template.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle_template
            // 
            this.lblTitle_template.Location = new System.Drawing.Point(350, 7);
            // 
            // pnlGrid_template
            // 
            this.pnlGrid_template.Size = new System.Drawing.Size(782, 323);
            // 
            // gbxSearch_template
            // 
            this.gbxSearch_template.Controls.Add(this.comboBox2);
            this.gbxSearch_template.Controls.SetChildIndex(this.lblSearch_template, 0);
            this.gbxSearch_template.Controls.SetChildIndex(this.comboBox2, 0);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(14, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(418, 25);
            this.comboBox2.TabIndex = 39;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmCajaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCajaPagos";
            this.Text = "frmCajaPagos";
            this.Load += new System.EventHandler(this.frmCajaPagos_Load);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
    }
}