namespace CapaPresentacion.caja
{
    partial class frmPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle_template = new System.Windows.Forms.Label();
            this.pnlGrid_template = new System.Windows.Forms.Panel();
            this.dgv_template = new System.Windows.Forms.DataGridView();
            this.gbxSearch_template = new System.Windows.Forms.GroupBox();
            this.lblSearch_template = new System.Windows.Forms.Label();
            this.abonar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlGrid_template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_template)).BeginInit();
            this.gbxSearch_template.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle_template
            // 
            this.lblTitle_template.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle_template.AutoSize = true;
            this.lblTitle_template.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_template.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle_template.Location = new System.Drawing.Point(393, 7);
            this.lblTitle_template.Name = "lblTitle_template";
            this.lblTitle_template.Size = new System.Drawing.Size(72, 32);
            this.lblTitle_template.TabIndex = 85;
            this.lblTitle_template.Text = "TITLE";
            this.lblTitle_template.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlGrid_template
            // 
            this.pnlGrid_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid_template.Controls.Add(this.dgv_template);
            this.pnlGrid_template.Location = new System.Drawing.Point(9, 128);
            this.pnlGrid_template.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGrid_template.Name = "pnlGrid_template";
            this.pnlGrid_template.Size = new System.Drawing.Size(869, 421);
            this.pnlGrid_template.TabIndex = 87;
            // 
            // dgv_template
            // 
            this.dgv_template.AllowUserToAddRows = false;
            this.dgv_template.AllowUserToDeleteRows = false;
            this.dgv_template.AllowUserToOrderColumns = true;
            this.dgv_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_template.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_template.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_template.BackgroundColor = System.Drawing.Color.White;
            this.dgv_template.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_template.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abonar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_template.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_template.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_template.Location = new System.Drawing.Point(11, 14);
            this.dgv_template.Name = "dgv_template";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_template.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_template.RowHeadersWidth = 51;
            this.dgv_template.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_template.Size = new System.Drawing.Size(844, 394);
            this.dgv_template.TabIndex = 38;
            // 
            // gbxSearch_template
            // 
            this.gbxSearch_template.Controls.Add(this.lblSearch_template);
            this.gbxSearch_template.Location = new System.Drawing.Point(20, 47);
            this.gbxSearch_template.Name = "gbxSearch_template";
            this.gbxSearch_template.Size = new System.Drawing.Size(450, 73);
            this.gbxSearch_template.TabIndex = 86;
            this.gbxSearch_template.TabStop = false;
            // 
            // lblSearch_template
            // 
            this.lblSearch_template.AutoSize = true;
            this.lblSearch_template.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_template.Location = new System.Drawing.Point(11, 12);
            this.lblSearch_template.Name = "lblSearch_template";
            this.lblSearch_template.Size = new System.Drawing.Size(90, 17);
            this.lblSearch_template.TabIndex = 2;
            this.lblSearch_template.Text = "Estado Pagos";
            // 
            // abonar
            // 
            this.abonar.HeaderText = "Abonar";
            this.abonar.Image = global::CapaPresentacion.Properties.Resources.writing;
            this.abonar.MinimumWidth = 6;
            this.abonar.Name = "abonar";
            this.abonar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abonar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.abonar.Width = 66;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 548);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGrid_template);
            this.Controls.Add(this.gbxSearch_template);
            this.Controls.Add(this.lblTitle_template);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagos";
            this.Text = "Caja/Cobros";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.pnlGrid_template.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_template)).EndInit();
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle_template;
        public System.Windows.Forms.Panel pnlGrid_template;
        public System.Windows.Forms.DataGridView dgv_template;
        public System.Windows.Forms.GroupBox gbxSearch_template;
        public System.Windows.Forms.Label lblSearch_template;
        private System.Windows.Forms.DataGridViewImageColumn abonar;
    }
}