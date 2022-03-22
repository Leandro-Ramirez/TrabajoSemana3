namespace Presentacion
{
    partial class FrmActivo
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtValorR = new System.Windows.Forms.TextBox();
            this.TxtVidaU = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblValorR = new System.Windows.Forms.Label();
            this.LblVidaU = new System.Windows.Forms.Label();
            this.DgvActivo = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GbBotones = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GbInformacion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivo)).BeginInit();
            this.GbBotones.SuspendLayout();
            this.GbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(7, 22);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(130, 22);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 22);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(130, 52);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 22);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress_1);
            // 
            // TxtValorR
            // 
            this.TxtValorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorR.Location = new System.Drawing.Point(130, 82);
            this.TxtValorR.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorR.Name = "TxtValorR";
            this.TxtValorR.Size = new System.Drawing.Size(100, 22);
            this.TxtValorR.TabIndex = 2;
            this.TxtValorR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorR_KeyPress);
            // 
            // TxtVidaU
            // 
            this.TxtVidaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVidaU.Location = new System.Drawing.Point(130, 112);
            this.TxtVidaU.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVidaU.Name = "TxtVidaU";
            this.TxtVidaU.Size = new System.Drawing.Size(100, 22);
            this.TxtVidaU.TabIndex = 3;
            this.TxtVidaU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVidaU_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(55, 25);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(67, 16);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(73, 55);
            this.LblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(49, 16);
            this.LblValor.TabIndex = 2;
            this.LblValor.Text = "Valor:";
            // 
            // LblValorR
            // 
            this.LblValorR.AutoSize = true;
            this.LblValorR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorR.Location = new System.Drawing.Point(7, 85);
            this.LblValorR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblValorR.Name = "LblValorR";
            this.LblValorR.Size = new System.Drawing.Size(115, 16);
            this.LblValorR.TabIndex = 3;
            this.LblValorR.Text = "Valor Residual:";
            // 
            // LblVidaU
            // 
            this.LblVidaU.AutoSize = true;
            this.LblVidaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVidaU.Location = new System.Drawing.Point(51, 115);
            this.LblVidaU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVidaU.Name = "LblVidaU";
            this.LblVidaU.Size = new System.Drawing.Size(71, 16);
            this.LblVidaU.TabIndex = 4;
            this.LblVidaU.Text = "Vida Util:";
            // 
            // DgvActivo
            // 
            this.DgvActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActivo.Location = new System.Drawing.Point(312, 13);
            this.DgvActivo.Margin = new System.Windows.Forms.Padding(4);
            this.DgvActivo.Name = "DgvActivo";
            this.DgvActivo.RowHeadersWidth = 62;
            this.DgvActivo.Size = new System.Drawing.Size(532, 285);
            this.DgvActivo.TabIndex = 0;
            this.DgvActivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActivo_CellContentClick);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(7, 59);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 30);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(114, 59);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GbBotones
            // 
            this.GbBotones.Controls.Add(this.BtnSalir);
            this.GbBotones.Controls.Add(this.BtnMostrar);
            this.GbBotones.Controls.Add(this.BtnLimpiar);
            this.GbBotones.Controls.Add(this.BtnGuardar);
            this.GbBotones.Controls.Add(this.BtnEliminar);
            this.GbBotones.Controls.Add(this.BtnActualizar);
            this.GbBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBotones.Location = new System.Drawing.Point(12, 166);
            this.GbBotones.Name = "GbBotones";
            this.GbBotones.Size = new System.Drawing.Size(220, 133);
            this.GbBotones.TabIndex = 1;
            this.GbBotones.TabStop = false;
            this.GbBotones.Text = "Botones:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(114, 95);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 30);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(114, 23);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(100, 30);
            this.BtnMostrar.TabIndex = 13;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(7, 95);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // GbInformacion
            // 
            this.GbInformacion.Controls.Add(this.LblValorR);
            this.GbInformacion.Controls.Add(this.TxtNombre);
            this.GbInformacion.Controls.Add(this.TxtValor);
            this.GbInformacion.Controls.Add(this.LblVidaU);
            this.GbInformacion.Controls.Add(this.TxtValorR);
            this.GbInformacion.Controls.Add(this.TxtVidaU);
            this.GbInformacion.Controls.Add(this.LblValor);
            this.GbInformacion.Controls.Add(this.LblNombre);
            this.GbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInformacion.Location = new System.Drawing.Point(12, 12);
            this.GbInformacion.Name = "GbInformacion";
            this.GbInformacion.Size = new System.Drawing.Size(293, 148);
            this.GbInformacion.TabIndex = 0;
            this.GbInformacion.TabStop = false;
            this.GbInformacion.Text = "Informacion:";
            // 
            // FrmActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 311);
            this.Controls.Add(this.GbInformacion);
            this.Controls.Add(this.GbBotones);
            this.Controls.Add(this.DgvActivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActivo";
            this.Text = "Activos";
            this.Load += new System.EventHandler(this.FrmActivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivo)).EndInit();
            this.GbBotones.ResumeLayout(false);
            this.GbInformacion.ResumeLayout(false);
            this.GbInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtValorR;
        private System.Windows.Forms.TextBox TxtVidaU;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblValorR;
        private System.Windows.Forms.Label LblVidaU;
        private System.Windows.Forms.DataGridView DgvActivo;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GbBotones;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox GbInformacion;
    }
}

