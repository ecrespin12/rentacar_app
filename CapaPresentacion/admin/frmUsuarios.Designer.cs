namespace CapaPresentacion.admin
{
    partial class frmUsuarios
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigoaux = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbestatus = new System.Windows.Forms.CheckBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpfechacreacion = new System.Windows.Forms.DateTimePicker();
            this.gbxSearch_template.SuspendLayout();
            this.pnlModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo_template
            // 
            this.btnNuevo_template.Location = new System.Drawing.Point(649, 59);
            this.btnNuevo_template.Click += new System.EventHandler(this.btnNuevo_template_Click);
            // 
            // pnlModal
            // 
            this.pnlModal.Controls.Add(this.dtpfechacreacion);
            this.pnlModal.Controls.Add(this.txtciudad);
            this.pnlModal.Controls.Add(this.label10);
            this.pnlModal.Controls.Add(this.txtestado);
            this.pnlModal.Controls.Add(this.label9);
            this.pnlModal.Controls.Add(this.txtpais);
            this.pnlModal.Controls.Add(this.label8);
            this.pnlModal.Controls.Add(this.cbestatus);
            this.pnlModal.Controls.Add(this.txtcodigoaux);
            this.pnlModal.Controls.Add(this.label7);
            this.pnlModal.Controls.Add(this.label6);
            this.pnlModal.Controls.Add(this.txtpassword);
            this.pnlModal.Controls.Add(this.label5);
            this.pnlModal.Controls.Add(this.txtcorreo);
            this.pnlModal.Controls.Add(this.label4);
            this.pnlModal.Controls.Add(this.txtapellido);
            this.pnlModal.Controls.Add(this.label3);
            this.pnlModal.Controls.Add(this.txtNombre);
            this.pnlModal.Controls.Add(this.label2);
            this.pnlModal.Controls.Add(this.label1);
            this.pnlModal.Controls.Add(this.txtCodigo);
            this.pnlModal.Location = new System.Drawing.Point(42, 23);
            this.pnlModal.Size = new System.Drawing.Size(600, 386);
            this.pnlModal.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnlModal.Controls.SetChildIndex(this.label1, 0);
            this.pnlModal.Controls.SetChildIndex(this.label2, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnCloseModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.btnAccionModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.lblTituloModal, 0);
            this.pnlModal.Controls.SetChildIndex(this.label3, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtapellido, 0);
            this.pnlModal.Controls.SetChildIndex(this.label4, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtcorreo, 0);
            this.pnlModal.Controls.SetChildIndex(this.label5, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtpassword, 0);
            this.pnlModal.Controls.SetChildIndex(this.label6, 0);
            this.pnlModal.Controls.SetChildIndex(this.label7, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtcodigoaux, 0);
            this.pnlModal.Controls.SetChildIndex(this.cbestatus, 0);
            this.pnlModal.Controls.SetChildIndex(this.label8, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtpais, 0);
            this.pnlModal.Controls.SetChildIndex(this.label9, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtestado, 0);
            this.pnlModal.Controls.SetChildIndex(this.label10, 0);
            this.pnlModal.Controls.SetChildIndex(this.txtciudad, 0);
            this.pnlModal.Controls.SetChildIndex(this.dtpfechacreacion, 0);
            // 
            // btnCloseModal
            // 
            this.btnCloseModal.Location = new System.Drawing.Point(557, -1);
            // 
            // btnAccionModal
            // 
            this.btnAccionModal.Location = new System.Drawing.Point(245, 343);
            this.btnAccionModal.Click += new System.EventHandler(this.btnAccionModal_Click_1);
            // 
            // lblTituloModal
            // 
            this.lblTituloModal.Location = new System.Drawing.Point(269, 7);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(34, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(313, 99);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(250, 20);
            this.txtapellido.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(34, 140);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(250, 20);
            this.txtcorreo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(313, 140);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(250, 20);
            this.txtpassword.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha creacion";
            // 
            // txtcodigoaux
            // 
            this.txtcodigoaux.Location = new System.Drawing.Point(34, 183);
            this.txtcodigoaux.Name = "txtcodigoaux";
            this.txtcodigoaux.Size = new System.Drawing.Size(250, 20);
            this.txtcodigoaux.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Codigo Aux";
            // 
            // cbestatus
            // 
            this.cbestatus.AutoSize = true;
            this.cbestatus.Location = new System.Drawing.Point(34, 225);
            this.cbestatus.Name = "cbestatus";
            this.cbestatus.Size = new System.Drawing.Size(56, 17);
            this.cbestatus.TabIndex = 17;
            this.cbestatus.Text = "Activo";
            this.cbestatus.UseVisualStyleBackColor = true;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(313, 183);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(250, 20);
            this.txtpais.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pais";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(313, 225);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(250, 20);
            this.txtestado.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(313, 269);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(250, 20);
            this.txtciudad.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ciudad";
            // 
            // dtpfechacreacion
            // 
            this.dtpfechacreacion.Location = new System.Drawing.Point(313, 60);
            this.dtpfechacreacion.Name = "dtpfechacreacion";
            this.dtpfechacreacion.Size = new System.Drawing.Size(200, 20);
            this.dtpfechacreacion.TabIndex = 24;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.gbxSearch_template.ResumeLayout(false);
            this.gbxSearch_template.PerformLayout();
            this.pnlModal.ResumeLayout(false);
            this.pnlModal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbestatus;
        private System.Windows.Forms.TextBox txtcodigoaux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfechacreacion;
    }
}