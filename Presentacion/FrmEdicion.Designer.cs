namespace practicaDepreciacion
{
    partial class FrmEdicion
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
            this.lblID = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbEdicion = new System.Windows.Forms.GroupBox();
            this.txtVIdaUtilMOD = new System.Windows.Forms.TextBox();
            this.txtValorResidualMOD = new System.Windows.Forms.TextBox();
            this.txtValorMOD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbBotones = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbEdicion.SuspendLayout();
            this.GbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(154, 19);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 16);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "lblID";
            this.lblID.Visible = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Red;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRegresar.Location = new System.Drawing.Point(174, 22);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(154, 48);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Blue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(12, 22);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 48);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnActualizarD_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(157, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vida util:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor residual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // GbEdicion
            // 
            this.GbEdicion.Controls.Add(this.txtVIdaUtilMOD);
            this.GbEdicion.Controls.Add(this.txtValorResidualMOD);
            this.GbEdicion.Controls.Add(this.txtValorMOD);
            this.GbEdicion.Controls.Add(this.label6);
            this.GbEdicion.Controls.Add(this.label1);
            this.GbEdicion.Controls.Add(this.lblID);
            this.GbEdicion.Controls.Add(this.label2);
            this.GbEdicion.Controls.Add(this.label3);
            this.GbEdicion.Controls.Add(this.label4);
            this.GbEdicion.Controls.Add(this.txtNombre);
            this.GbEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEdicion.Location = new System.Drawing.Point(41, 47);
            this.GbEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.GbEdicion.Name = "GbEdicion";
            this.GbEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.GbEdicion.Size = new System.Drawing.Size(584, 227);
            this.GbEdicion.TabIndex = 0;
            this.GbEdicion.TabStop = false;
            this.GbEdicion.Text = "Datos a Editar:";
            // 
            // txtVIdaUtilMOD
            // 
            this.txtVIdaUtilMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVIdaUtilMOD.Location = new System.Drawing.Point(157, 166);
            this.txtVIdaUtilMOD.Margin = new System.Windows.Forms.Padding(4);
            this.txtVIdaUtilMOD.Name = "txtVIdaUtilMOD";
            this.txtVIdaUtilMOD.Size = new System.Drawing.Size(150, 22);
            this.txtVIdaUtilMOD.TabIndex = 9;
            // 
            // txtValorResidualMOD
            // 
            this.txtValorResidualMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorResidualMOD.Location = new System.Drawing.Point(157, 125);
            this.txtValorResidualMOD.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorResidualMOD.Name = "txtValorResidualMOD";
            this.txtValorResidualMOD.Size = new System.Drawing.Size(150, 22);
            this.txtValorResidualMOD.TabIndex = 8;
            // 
            // txtValorMOD
            // 
            this.txtValorMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMOD.Location = new System.Drawing.Point(157, 92);
            this.txtValorMOD.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorMOD.Name = "txtValorMOD";
            this.txtValorMOD.Size = new System.Drawing.Size(150, 22);
            this.txtValorMOD.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id:";
            // 
            // GbBotones
            // 
            this.GbBotones.Controls.Add(this.BtnRegresar);
            this.GbBotones.Controls.Add(this.btnModificar);
            this.GbBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBotones.Location = new System.Drawing.Point(207, 281);
            this.GbBotones.Name = "GbBotones";
            this.GbBotones.Size = new System.Drawing.Size(354, 86);
            this.GbBotones.TabIndex = 1;
            this.GbBotones.TabStop = false;
            this.GbBotones.Text = "Botones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modificar Activo";
            // 
            // FrmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GbBotones);
            this.Controls.Add(this.GbEdicion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEdicion";
            this.Text = "Edicion";
            this.GbEdicion.ResumeLayout(false);
            this.GbEdicion.PerformLayout();
            this.GbBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbEdicion;
        private System.Windows.Forms.GroupBox GbBotones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtVIdaUtilMOD;
        public System.Windows.Forms.TextBox txtValorResidualMOD;
        public System.Windows.Forms.TextBox txtValorMOD;
    }
}