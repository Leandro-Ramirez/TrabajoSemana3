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
            this.TxtId = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnActualizarD = new System.Windows.Forms.Button();
            this.NudVidaU = new System.Windows.Forms.NumericUpDown();
            this.NudValorR = new System.Windows.Forms.NumericUpDown();
            this.NudValor = new System.Windows.Forms.NumericUpDown();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbEdicion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbBotones = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudVidaU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudValorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudValor)).BeginInit();
            this.GbEdicion.SuspendLayout();
            this.GbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.AutoSize = true;
            this.TxtId.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(114, 21);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(36, 15);
            this.TxtId.TabIndex = 6;
            this.TxtId.Text = "TxtId";
            this.TxtId.Visible = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.Red;
            this.BtnRegresar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRegresar.Location = new System.Drawing.Point(115, 21);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(100, 30);
            this.BtnRegresar.TabIndex = 1;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnActualizarD
            // 
            this.BtnActualizarD.BackColor = System.Drawing.Color.Blue;
            this.BtnActualizarD.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarD.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnActualizarD.Location = new System.Drawing.Point(7, 21);
            this.BtnActualizarD.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizarD.Name = "BtnActualizarD";
            this.BtnActualizarD.Size = new System.Drawing.Size(100, 30);
            this.BtnActualizarD.TabIndex = 0;
            this.BtnActualizarD.Text = "Actualizar";
            this.BtnActualizarD.UseVisualStyleBackColor = false;
            this.BtnActualizarD.Click += new System.EventHandler(this.BtnActualizarD_Click);
            // 
            // NudVidaU
            // 
            this.NudVidaU.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudVidaU.Location = new System.Drawing.Point(117, 137);
            this.NudVidaU.Margin = new System.Windows.Forms.Padding(4);
            this.NudVidaU.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudVidaU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudVidaU.Name = "NudVidaU";
            this.NudVidaU.Size = new System.Drawing.Size(100, 21);
            this.NudVidaU.TabIndex = 2;
            this.NudVidaU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudValorR
            // 
            this.NudValorR.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudValorR.Location = new System.Drawing.Point(117, 108);
            this.NudValorR.Margin = new System.Windows.Forms.Padding(4);
            this.NudValorR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudValorR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudValorR.Name = "NudValorR";
            this.NudValorR.Size = new System.Drawing.Size(100, 21);
            this.NudValorR.TabIndex = 1;
            this.NudValorR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudValor
            // 
            this.NudValor.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudValor.Location = new System.Drawing.Point(117, 79);
            this.NudValor.Margin = new System.Windows.Forms.Padding(4);
            this.NudValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudValor.Name = "NudValor";
            this.NudValor.Size = new System.Drawing.Size(100, 21);
            this.NudValor.TabIndex = 0;
            this.NudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(117, 50);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 21);
            this.TxtNombre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vida util:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor residual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // GbEdicion
            // 
            this.GbEdicion.Controls.Add(this.label6);
            this.GbEdicion.Controls.Add(this.label1);
            this.GbEdicion.Controls.Add(this.TxtId);
            this.GbEdicion.Controls.Add(this.label2);
            this.GbEdicion.Controls.Add(this.label3);
            this.GbEdicion.Controls.Add(this.label4);
            this.GbEdicion.Controls.Add(this.NudVidaU);
            this.GbEdicion.Controls.Add(this.TxtNombre);
            this.GbEdicion.Controls.Add(this.NudValorR);
            this.GbEdicion.Controls.Add(this.NudValor);
            this.GbEdicion.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEdicion.Location = new System.Drawing.Point(13, 42);
            this.GbEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.GbEdicion.Name = "GbEdicion";
            this.GbEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.GbEdicion.Size = new System.Drawing.Size(282, 175);
            this.GbEdicion.TabIndex = 0;
            this.GbEdicion.TabStop = false;
            this.GbEdicion.Text = "Datos a Editar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Id:";
            // 
            // GbBotones
            // 
            this.GbBotones.Controls.Add(this.BtnRegresar);
            this.GbBotones.Controls.Add(this.BtnActualizarD);
            this.GbBotones.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBotones.Location = new System.Drawing.Point(42, 224);
            this.GbBotones.Name = "GbBotones";
            this.GbBotones.Size = new System.Drawing.Size(225, 67);
            this.GbBotones.TabIndex = 1;
            this.GbBotones.TabStop = false;
            this.GbBotones.Text = "Botones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Actualizar Datos";
            // 
            // FrmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GbBotones);
            this.Controls.Add(this.GbEdicion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEdicion";
            this.Text = "Edicion";
            ((System.ComponentModel.ISupportInitialize)(this.NudVidaU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudValorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudValor)).EndInit();
            this.GbEdicion.ResumeLayout(false);
            this.GbEdicion.PerformLayout();
            this.GbBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TxtId;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnActualizarD;
        public System.Windows.Forms.NumericUpDown NudVidaU;
        public System.Windows.Forms.NumericUpDown NudValorR;
        public System.Windows.Forms.NumericUpDown NudValor;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbEdicion;
        private System.Windows.Forms.GroupBox GbBotones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}