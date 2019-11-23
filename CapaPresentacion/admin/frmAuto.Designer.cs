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
            this.epErrorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bD_AlquilerAutosDataSet = new CapaPresentacion.BD_AlquilerAutosDataSet();
            this.tblmarmarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mar_marcaTableAdapter = new CapaPresentacion.BD_AlquilerAutosDataSetTableAdapters.tbl_mar_marcaTableAdapter();
            this.bD_AlquilerAutosDataSet1 = new CapaPresentacion.BD_AlquilerAutosDataSet1();
            this.tblcolcolorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_col_colorTableAdapter = new CapaPresentacion.BD_AlquilerAutosDataSet1TableAdapters.tbl_col_colorTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bD_AlquilerAutosDataSetTipoAuto = new CapaPresentacion.BD_AlquilerAutosDataSetTipoAuto();
            this.tbltiatipoautoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_tia_tipo_autoTableAdapter = new CapaPresentacion.BD_AlquilerAutosDataSetTipoAutoTableAdapters.tbl_tia_tipo_autoTableAdapter();
            this.gbxSearch_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlquilerAutosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmarmarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlquilerAutosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcolcolorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlquilerAutosDataSetTipoAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltiatipoautoBindingSource)).BeginInit();
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
            this.pnlModal.Controls.Add(this.comboBox3);
            this.pnlModal.Controls.Add(this.comboBox2);
            this.pnlModal.Controls.Add(this.comboBox1);
            this.pnlModal.Controls.Add(this.label2);
            this.pnlModal.Controls.Add(this.label1);
            this.pnlModal.Controls.Add(this.txtCodigo);
            this.pnlModal.Controls.Add(this.lblEstado);
            this.pnlModal.Location = new System.Drawing.Point(194, 58);
            this.pnlModal.Size = new System.Drawing.Size(479, 435);
            this.pnlModal.Controls.SetChildIndex(this.lblEstado, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.label1, 0);
            this.pnlModal.Controls.SetChildIndex(this.label2, 0);
            this.pnlModal.Controls.SetChildIndex(this.comboBox1, 0);
            this.pnlModal.Controls.SetChildIndex(this.comboBox2, 0);
            this.pnlModal.Controls.SetChildIndex(this.comboBox3, 0);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de auto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblmarmarcaBindingSource;
            this.comboBox1.DisplayMember = "mar_nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "mar_codigo";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblcolcolorBindingSource;
            this.comboBox2.DisplayMember = "col_nombre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "col_codigo";
            // 
            // bD_AlquilerAutosDataSet
            // 
            this.bD_AlquilerAutosDataSet.DataSetName = "BD_AlquilerAutosDataSet";
            this.bD_AlquilerAutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmarmarcaBindingSource
            // 
            this.tblmarmarcaBindingSource.DataMember = "tbl_mar_marca";
            this.tblmarmarcaBindingSource.DataSource = this.bD_AlquilerAutosDataSet;
            // 
            // tbl_mar_marcaTableAdapter
            // 
            this.tbl_mar_marcaTableAdapter.ClearBeforeFill = true;
            // 
            // bD_AlquilerAutosDataSet1
            // 
            this.bD_AlquilerAutosDataSet1.DataSetName = "BD_AlquilerAutosDataSet1";
            this.bD_AlquilerAutosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcolcolorBindingSource
            // 
            this.tblcolcolorBindingSource.DataMember = "tbl_col_color";
            this.tblcolcolorBindingSource.DataSource = this.bD_AlquilerAutosDataSet1;
            // 
            // tbl_col_colorTableAdapter
            // 
            this.tbl_col_colorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tbltiatipoautoBindingSource;
            this.comboBox3.DisplayMember = "tia_nombre";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(115, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.ValueMember = "tia_codigo";
            // 
            // bD_AlquilerAutosDataSetTipoAuto
            // 
            this.bD_AlquilerAutosDataSetTipoAuto.DataSetName = "BD_AlquilerAutosDataSetTipoAuto";
            this.bD_AlquilerAutosDataSetTipoAuto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltiatipoautoBindingSource
            // 
            this.tbltiatipoautoBindingSource.DataMember = "tbl_tia_tipo_auto";
            this.tbltiatipoautoBindingSource.DataSource = this.bD_AlquilerAutosDataSetTipoAuto;
            // 
            // tbl_tia_tipo_autoTableAdapter
            // 
            this.tbl_tia_tipo_autoTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlquilerAutosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmarmarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlquilerAutosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcolcolorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_AlquilerAutosDataSetTipoAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltiatipoautoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ErrorProvider epErrorEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private BD_AlquilerAutosDataSet bD_AlquilerAutosDataSet;
        private System.Windows.Forms.BindingSource tblmarmarcaBindingSource;
        private BD_AlquilerAutosDataSetTableAdapters.tbl_mar_marcaTableAdapter tbl_mar_marcaTableAdapter;
        private BD_AlquilerAutosDataSet1 bD_AlquilerAutosDataSet1;
        private System.Windows.Forms.BindingSource tblcolcolorBindingSource;
        private BD_AlquilerAutosDataSet1TableAdapters.tbl_col_colorTableAdapter tbl_col_colorTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private BD_AlquilerAutosDataSetTipoAuto bD_AlquilerAutosDataSetTipoAuto;
        private System.Windows.Forms.BindingSource tbltiatipoautoBindingSource;
        private BD_AlquilerAutosDataSetTipoAutoTableAdapters.tbl_tia_tipo_autoTableAdapter tbl_tia_tipo_autoTableAdapter;
    }
}