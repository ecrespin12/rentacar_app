namespace CapaPresentacion
{
    partial class FrmModal
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
            this.pnlModal = new System.Windows.Forms.Panel();
            this.lblTituloModal = new System.Windows.Forms.Label();
            this.btnAccionModal = new System.Windows.Forms.Button();
            this.btnCloseModal = new System.Windows.Forms.Button();
            this.pnlModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModal
            // 
            this.pnlModal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlModal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModal.Controls.Add(this.lblTituloModal);
            this.pnlModal.Controls.Add(this.btnAccionModal);
            this.pnlModal.Controls.Add(this.btnCloseModal);
            this.pnlModal.Location = new System.Drawing.Point(122, 12);
            this.pnlModal.Name = "pnlModal";
            this.pnlModal.Size = new System.Drawing.Size(495, 474);
            this.pnlModal.TabIndex = 0;
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloModal.AutoSize = true;
            this.lblTituloModal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModal.Location = new System.Drawing.Point(205, 9);
            this.lblTituloModal.Name = "lblTituloModal";
            this.lblTituloModal.Size = new System.Drawing.Size(86, 30);
            this.lblTituloModal.TabIndex = 2;
            this.lblTituloModal.Text = "TITULO";
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAccionModal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccionModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccionModal.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccionModal.ForeColor = System.Drawing.Color.White;
            this.btnAccionModal.Location = new System.Drawing.Point(173, 422);
            this.btnAccionModal.Name = "btnAccionModal";
            this.btnAccionModal.Size = new System.Drawing.Size(152, 37);
            this.btnAccionModal.TabIndex = 1;
            this.btnAccionModal.Text = "ACCION";
            this.btnAccionModal.UseVisualStyleBackColor = false;
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseModal.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseModal.ForeColor = System.Drawing.Color.White;
            this.btnCloseModal.Location = new System.Drawing.Point(438, -1);
            this.btnCloseModal.Name = "btnCloseModal";
            this.btnCloseModal.Size = new System.Drawing.Size(56, 36);
            this.btnCloseModal.TabIndex = 0;
            this.btnCloseModal.Text = "X";
            this.btnCloseModal.UseVisualStyleBackColor = false;
            // 
            // FrmModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 512);
            this.Controls.Add(this.pnlModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlModal;
        public System.Windows.Forms.Button btnCloseModal;
        public System.Windows.Forms.Button btnAccionModal;
        public System.Windows.Forms.Label lblTituloModal;
    }
}