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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAutosDisponibles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtDolar2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoCobrar = new System.Windows.Forms.TextBox();
            this.btnGuardarRenta = new System.Windows.Forms.Button();
            this.gbxCantidadRecibos = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.panel16.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDisponibles)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.panel10.SuspendLayout();
            this.gbxCantidadRecibos.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel16.Size = new System.Drawing.Size(601, 487);
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
            this.panel7.Size = new System.Drawing.Size(588, 31);
            this.panel7.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(152, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 20);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutosDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutosDisponibles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutosDisponibles.Location = new System.Drawing.Point(7, 42);
            this.dgvAutosDisponibles.MultiSelect = false;
            this.dgvAutosDisponibles.Name = "dgvAutosDisponibles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutosDisponibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAutosDisponibles.RowHeadersVisible = false;
            this.dgvAutosDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvAutosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAutosDisponibles.Size = new System.Drawing.Size(588, 431);
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
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "RENTA DE VEHICULOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(619, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 487);
            this.panel1.TabIndex = 83;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.gbTotal);
            this.panel8.Controls.Add(this.btnGuardarRenta);
            this.panel8.Controls.Add(this.gbxCantidadRecibos);
            this.panel8.Location = new System.Drawing.Point(7, 37);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(429, 436);
            this.panel8.TabIndex = 82;
            // 
            // gbTotal
            // 
            this.gbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.gbTotal.Controls.Add(this.dtpHasta);
            this.gbTotal.Controls.Add(this.label5);
            this.gbTotal.Controls.Add(this.label4);
            this.gbTotal.Controls.Add(this.dtpDesde);
            this.gbTotal.Controls.Add(this.txtDeposito);
            this.gbTotal.Controls.Add(this.label3);
            this.gbTotal.Controls.Add(this.panel10);
            this.gbTotal.Location = new System.Drawing.Point(36, 91);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(365, 234);
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
            this.panel10.Location = new System.Drawing.Point(28, 134);
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
            this.label18.Size = new System.Drawing.Size(107, 17);
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
            this.btnGuardarRenta.Location = new System.Drawing.Point(36, 331);
            this.btnGuardarRenta.Name = "btnGuardarRenta";
            this.btnGuardarRenta.Size = new System.Drawing.Size(365, 58);
            this.btnGuardarRenta.TabIndex = 101;
            this.btnGuardarRenta.Text = "PROCESAR RENTA";
            this.btnGuardarRenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarRenta.UseVisualStyleBackColor = false;
            this.btnGuardarRenta.Visible = false;
            this.btnGuardarRenta.Click += new System.EventHandler(this.BtnGuardarRenta_Click);
            // 
            // gbxCantidadRecibos
            // 
            this.gbxCantidadRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCantidadRecibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.gbxCantidadRecibos.Controls.Add(this.btnProcesar);
            this.gbxCantidadRecibos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCantidadRecibos.Location = new System.Drawing.Point(36, 17);
            this.gbxCantidadRecibos.Name = "gbxCantidadRecibos";
            this.gbxCantidadRecibos.Size = new System.Drawing.Size(365, 68);
            this.gbxCantidadRecibos.TabIndex = 91;
            this.gbxCantidadRecibos.TabStop = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(28, 22);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(310, 31);
            this.btnProcesar.TabIndex = 68;
            this.btnProcesar.Text = "VERIFICAR INFORMACION";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
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
            this.panel2.Size = new System.Drawing.Size(429, 31);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DETALLES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "DEPOSITO";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(28, 100);
            this.txtDeposito.Multiline = true;
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(169, 28);
            this.txtDeposito.TabIndex = 103;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(28, 45);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(155, 23);
            this.dtpDesde.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 105;
            this.label4.Text = "DESDE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 106;
            this.label5.Text = "HASTA";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(204, 45);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(155, 23);
            this.dtpHasta.TabIndex = 107;
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
            this.panel8.ResumeLayout(false);
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.gbxCantidadRecibos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}