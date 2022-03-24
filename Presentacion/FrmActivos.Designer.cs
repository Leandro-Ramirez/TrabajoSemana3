namespace practicaDepreciacion
{
    partial class FrmActivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.DgvActivos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.TxtVidaU = new System.Windows.Forms.TextBox();
            this.TxtValorR = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbInformacion = new System.Windows.Forms.GroupBox();
            this.GbAcciones = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivos)).BeginInit();
            this.GbInformacion.SuspendLayout();
            this.GbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Activos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEliminar.Location = new System.Drawing.Point(115, 56);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Blue;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnActualizar.Location = new System.Drawing.Point(7, 56);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 30);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DgvActivos
            // 
            this.DgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActivos.Location = new System.Drawing.Point(12, 184);
            this.DgvActivos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvActivos.Name = "DgvActivos";
            this.DgvActivos.RowHeadersWidth = 62;
            this.DgvActivos.Size = new System.Drawing.Size(506, 300);
            this.DgvActivos.TabIndex = 0;
            this.DgvActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActivos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vida util:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor residual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(50, 23);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(58, 15);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            // 
            // TxtVidaU
            // 
            this.TxtVidaU.Location = new System.Drawing.Point(116, 101);
            this.TxtVidaU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVidaU.Name = "TxtVidaU";
            this.TxtVidaU.Size = new System.Drawing.Size(100, 21);
            this.TxtVidaU.TabIndex = 3;
            this.TxtVidaU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVidaU_KeyPress);
            // 
            // TxtValorR
            // 
            this.TxtValorR.Location = new System.Drawing.Point(116, 74);
            this.TxtValorR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtValorR.Name = "TxtValorR";
            this.TxtValorR.Size = new System.Drawing.Size(100, 21);
            this.TxtValorR.TabIndex = 2;
            this.TxtValorR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorR_KeyPress);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(116, 47);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 21);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(116, 20);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 21);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Location = new System.Drawing.Point(7, 20);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GbInformacion
            // 
            this.GbInformacion.Controls.Add(this.TxtNombre);
            this.GbInformacion.Controls.Add(this.TxtValor);
            this.GbInformacion.Controls.Add(this.TxtValorR);
            this.GbInformacion.Controls.Add(this.TxtVidaU);
            this.GbInformacion.Controls.Add(this.Nombre);
            this.GbInformacion.Controls.Add(this.label4);
            this.GbInformacion.Controls.Add(this.label2);
            this.GbInformacion.Controls.Add(this.label3);
            this.GbInformacion.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInformacion.Location = new System.Drawing.Point(12, 46);
            this.GbInformacion.Name = "GbInformacion";
            this.GbInformacion.Size = new System.Drawing.Size(275, 132);
            this.GbInformacion.TabIndex = 0;
            this.GbInformacion.TabStop = false;
            this.GbInformacion.Text = "Informacion:";
            // 
            // GbAcciones
            // 
            this.GbAcciones.Controls.Add(this.BtnSalir);
            this.GbAcciones.Controls.Add(this.BtnLimpiar);
            this.GbAcciones.Controls.Add(this.BtnMostrar);
            this.GbAcciones.Controls.Add(this.BtnGuardar);
            this.GbAcciones.Controls.Add(this.BtnActualizar);
            this.GbAcciones.Controls.Add(this.BtnEliminar);
            this.GbAcciones.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAcciones.Location = new System.Drawing.Point(293, 48);
            this.GbAcciones.Name = "GbAcciones";
            this.GbAcciones.Size = new System.Drawing.Size(225, 130);
            this.GbAcciones.TabIndex = 1;
            this.GbAcciones.TabStop = false;
            this.GbAcciones.Text = "Acciones:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSalir.Location = new System.Drawing.Point(115, 92);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 30);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLimpiar.Location = new System.Drawing.Point(7, 92);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.Yellow;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnMostrar.Location = new System.Drawing.Point(115, 20);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(100, 30);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // FrmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 499);
            this.Controls.Add(this.GbAcciones);
            this.Controls.Add(this.GbInformacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvActivos);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmActivos";
            this.Text = "Activos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivos)).EndInit();
            this.GbInformacion.ResumeLayout(false);
            this.GbInformacion.PerformLayout();
            this.GbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView DgvActivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TxtVidaU;
        private System.Windows.Forms.TextBox TxtValorR;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox GbInformacion;
        private System.Windows.Forms.GroupBox GbAcciones;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

