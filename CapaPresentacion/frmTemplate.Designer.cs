namespace CapaPresentacion
{
    partial class frmTemplate
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
            this.gbxSearch_template = new System.Windows.Forms.GroupBox();
            this.lblSearch_template = new System.Windows.Forms.Label();
            this.txtSearch_template = new System.Windows.Forms.TextBox();
            this.lblTitle_template = new System.Windows.Forms.Label();
            this.pnlGrid_template = new System.Windows.Forms.Panel();
            this.dgv_template = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNuevo_template = new System.Windows.Forms.Button();
            this.pnlModal.SuspendLayout();
            this.gbxSearch_template.SuspendLayout();
            this.pnlGrid_template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_template)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlModal
            // 
            this.pnlModal.Location = new System.Drawing.Point(360, 12);
            this.pnlModal.Size = new System.Drawing.Size(430, 474);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(373, -1);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Location = new System.Drawing.Point(141, 422);
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Location = new System.Drawing.Point(173, 9);
            // 
            // gbxSearch_template
            // 
            this.gbxSearch_template.Controls.Add(this.lblSearch_template);
            this.gbxSearch_template.Controls.Add(this.txtSearch_template);
            this.gbxSearch_template.Location = new System.Drawing.Point(27, 58);
            this.gbxSearch_template.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearch_template.Name = "gbxSearch_template";
            this.gbxSearch_template.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearch_template.Size = new System.Drawing.Size(600, 90);
            this.gbxSearch_template.TabIndex = 46;
            this.gbxSearch_template.TabStop = false;
            // 
            // lblSearch_template
            // 
            this.lblSearch_template.AutoSize = true;
            this.lblSearch_template.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_template.Location = new System.Drawing.Point(15, 15);
            this.lblSearch_template.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch_template.Name = "lblSearch_template";
            this.lblSearch_template.Size = new System.Drawing.Size(60, 23);
            this.lblSearch_template.TabIndex = 2;
            this.lblSearch_template.Text = "Buscar";
            // 
            // txtSearch_template
            // 
            this.txtSearch_template.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch_template.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_template.Location = new System.Drawing.Point(19, 41);
            this.txtSearch_template.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch_template.MaxLength = 28;
            this.txtSearch_template.Multiline = true;
            this.txtSearch_template.Name = "txtSearch_template";
            this.txtSearch_template.Size = new System.Drawing.Size(556, 34);
            this.txtSearch_template.TabIndex = 0;
            // 
            // lblTitle_template
            // 
            this.lblTitle_template.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle_template.AutoSize = true;
            this.lblTitle_template.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_template.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle_template.Location = new System.Drawing.Point(524, 9);
            this.lblTitle_template.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_template.Name = "lblTitle_template";
            this.lblTitle_template.Size = new System.Drawing.Size(92, 41);
            this.lblTitle_template.TabIndex = 84;
            this.lblTitle_template.Text = "TITLE";
            // 
            // pnlGrid_template
            // 
            this.pnlGrid_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid_template.Controls.Add(this.dgv_template);
            this.pnlGrid_template.Location = new System.Drawing.Point(12, 158);
            this.pnlGrid_template.Name = "pnlGrid_template";
            this.pnlGrid_template.Size = new System.Drawing.Size(1159, 518);
            this.pnlGrid_template.TabIndex = 85;
            // 
            // dgv_template
            // 
            this.dgv_template.AllowUserToAddRows = false;
            this.dgv_template.AllowUserToDeleteRows = false;
            this.dgv_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_template.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_template.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_template.BackgroundColor = System.Drawing.Color.White;
            this.dgv_template.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_template.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_template.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.eliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_template.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_template.Location = new System.Drawing.Point(15, 17);
            this.dgv_template.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgv_template.Size = new System.Drawing.Size(1126, 485);
            this.dgv_template.TabIndex = 38;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = global::CapaPresentacion.Properties.Resources.writing;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editar.Width = 74;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::CapaPresentacion.Properties.Resources.writing;
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 87;
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo_template.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo_template.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo_template.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo_template.ForeColor = System.Drawing.Color.White;
            this.btnNuevo_template.Location = new System.Drawing.Point(1001, 99);
            this.btnNuevo_template.Name = "btnNuevo_template";
            this.btnNuevo_template.Size = new System.Drawing.Size(152, 37);
            this.btnNuevo_template.TabIndex = 86;
            this.btnNuevo_template.Text = "NUEVO";
            this.btnNuevo_template.UseVisualStyleBackColor = false;
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 688);
            this.Controls.Add(this.btnNuevo_template);
            this.Controls.Add(this.pnlGrid_template);
            this.Controls.Add(this.lblTitle_template);
            this.Controls.Add(this.gbxSearch_template);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmTemplate";
            this.Text = "frmTemplate";
            this.Controls.SetChildIndex(this.gbxSearch_template, 0);
            this.Controls.SetChildIndex(this.lblTitle_template, 0);
            this.Controls.SetChildIndex(this.pnlGrid_template, 0);
            this.Controls.SetChildIndex(this.pnlModal, 0);
            this.Controls.SetChildIndex(this.btnNuevo_template, 0);
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlGrid_template.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_template)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox gbxSearch_template;
        public System.Windows.Forms.Label lblSearch_template;
        public System.Windows.Forms.TextBox txtSearch_template;
        public System.Windows.Forms.Label lblTitle_template;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        public System.Windows.Forms.Panel pnlGrid_template;
        public System.Windows.Forms.DataGridView dgv_template;
        public System.Windows.Forms.Button btnNuevo_template;
    }
}