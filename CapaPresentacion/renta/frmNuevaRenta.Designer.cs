namespace CapaPresentacion.renta
{
    partial class frmNuevaRenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAutosDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtDolar2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoCobrar = new System.Windows.Forms.TextBox();
            this.btnGuardarRenta = new System.Windows.Forms.Button();
            this.gbxCantidadRecibos = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.panel16.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDisponibles)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.panel10.SuspendLayout();
            this.gbxCantidadRecibos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.Controls.Add(this.panel7);
            this.panel16.Controls.Add(this.dgvAutosDisponibles);
            this.panel16.Location = new System.Drawing.Point(12, 103);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(102, 487);
            this.panel16.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(7, 8);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(89, 31);
            this.panel7.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-98, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "LISTADO DE VEHICULOS EN ALQUILER";
            // 
            // dgvAutosDisponibles
            // 
            this.dgvAutosDisponibles.AllowUserToAddRows = false;
            this.dgvAutosDisponibles.AllowUserToDeleteRows = false;
            this.dgvAutosDisponibles.AllowUserToResizeColumns = false;
            this.dgvAutosDisponibles.AllowUserToResizeRows = false;
            this.dgvAutosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutosDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutosDisponibles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutosDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAutosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutosDisponibles.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAutosDisponibles.Location = new System.Drawing.Point(7, 42);
            this.dgvAutosDisponibles.MultiSelect = false;
            this.dgvAutosDisponibles.Name = "dgvAutosDisponibles";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutosDisponibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAutosDisponibles.RowHeadersVisible = false;
            this.dgvAutosDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvAutosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAutosDisponibles.Size = new System.Drawing.Size(89, 431);
            this.dgvAutosDisponibles.TabIndex = 9;
            this.dgvAutosDisponibles.Visible = false;
            this.dgvAutosDisponibles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAutosDisponibles_CellValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(412, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "RENTA DE VEHICULOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(120, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 487);
            this.panel1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 31);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DETALLES";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.cboBusqueda);
            this.panel8.Controls.Add(this.gbTotal);
            this.panel8.Controls.Add(this.btnGuardarRenta);
            this.panel8.Controls.Add(this.gbxCantidadRecibos);
            this.panel8.Location = new System.Drawing.Point(7, 37);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(928, 436);
            this.panel8.TabIndex = 82;
            // 
            // gbTotal
            // 
            this.gbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.gbTotal.Controls.Add(this.panel10);
            this.gbTotal.Location = new System.Drawing.Point(535, 91);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(365, 100);
            this.gbTotal.TabIndex = 106;
            this.gbTotal.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Controls.Add(this.txtDolar2);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.txtMontoCobrar);
            this.panel10.Location = new System.Drawing.Point(28, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(310, 82);
            this.panel10.TabIndex = 102;
            // 
            // txtDolar2
            // 
            this.txtDolar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDolar2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDolar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDolar2.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(6)))));
            this.txtDolar2.Location = new System.Drawing.Point(35, 25);
            this.txtDolar2.MaxLength = 8;
            this.txtDolar2.Multiline = true;
            this.txtDolar2.Name = "txtDolar2";
            this.txtDolar2.ReadOnly = true;
            this.txtDolar2.Size = new System.Drawing.Size(41, 50);
            this.txtDolar2.TabIndex = 98;
            this.txtDolar2.Text = "$";
            this.txtDolar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 17);
            this.label18.TabIndex = 94;
            this.label18.Text = "TOTAL A PAGAR";
            // 
            // txtMontoCobrar
            // 
            this.txtMontoCobrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMontoCobrar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMontoCobrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoCobrar.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(6)))));
            this.txtMontoCobrar.Location = new System.Drawing.Point(67, 25);
            this.txtMontoCobrar.MaxLength = 8;
            this.txtMontoCobrar.Multiline = true;
            this.txtMontoCobrar.Name = "txtMontoCobrar";
            this.txtMontoCobrar.ReadOnly = true;
            this.txtMontoCobrar.Size = new System.Drawing.Size(215, 50);
            this.txtMontoCobrar.TabIndex = 97;
            this.txtMontoCobrar.Text = "0.00";
            this.txtMontoCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardarRenta
            // 
            this.btnGuardarRenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarRenta.BackColor = System.Drawing.Color.Lavender;
            this.btnGuardarRenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarRenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRenta.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.btnGuardarRenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarRenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRenta.Location = new System.Drawing.Point(535, 197);
            this.btnGuardarRenta.Name = "btnGuardarRenta";
            this.btnGuardarRenta.Size = new System.Drawing.Size(365, 58);
            this.btnGuardarRenta.TabIndex = 101;
            this.btnGuardarRenta.Text = "PROCESAR RENTA";
            this.btnGuardarRenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarRenta.UseVisualStyleBackColor = false;
            this.btnGuardarRenta.Click += new System.EventHandler(this.BtnGuardarRenta_Click);
            // 
            // gbxCantidadRecibos
            // 
            this.gbxCantidadRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCantidadRecibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.gbxCantidadRecibos.Controls.Add(this.btnProcesar);
            this.gbxCantidadRecibos.Controls.Add(this.txtCantidad);
            this.gbxCantidadRecibos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCantidadRecibos.Location = new System.Drawing.Point(535, 17);
            this.gbxCantidadRecibos.Name = "gbxCantidadRecibos";
            this.gbxCantidadRecibos.Size = new System.Drawing.Size(365, 68);
            this.gbxCantidadRecibos.TabIndex = 91;
            this.gbxCantidadRecibos.TabStop = false;
            this.gbxCantidadRecibos.Text = "CANTIDAD DE RECIBOS A COBRAR";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(174, 24);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(145, 31);
            this.btnProcesar.TabIndex = 68;
            this.btnProcesar.Text = "GUARDAR RENTA";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(54, 25);
            this.txtCantidad.MaxLength = 3;
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 30);
            this.txtCantidad.TabIndex = 67;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(36, 60);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(152, 25);
            this.cboBusqueda.TabIndex = 107;
            // 
            // frmNuevaRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaRenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaRenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNuevaRenta_Load);
            this.panel16.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDisponibles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.gbTotal.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.gbxCantidadRecibos.ResumeLayout(false);
            this.gbxCantidadRecibos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dgvAutosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtDolar2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMontoCobrar;
        private System.Windows.Forms.Button btnGuardarRenta;
        private System.Windows.Forms.GroupBox gbxCantidadRecibos;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBusqueda;
    }
}