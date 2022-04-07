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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivos));
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
            this.cbEstadoActivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbAcciones = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivos)).BeginInit();
            this.GbInformacion.SuspendLayout();
            this.GbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Activos";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEliminar.Location = new System.Drawing.Point(17, 88);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 50);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Blue;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnActualizar.Location = new System.Drawing.Point(134, 88);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(109, 50);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Modificar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DgvActivos
            // 
            this.DgvActivos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvActivos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvActivos.GridColor = System.Drawing.Color.Maroon;
            this.DgvActivos.Location = new System.Drawing.Point(12, 397);
            this.DgvActivos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvActivos.Name = "DgvActivos";
            this.DgvActivos.RowHeadersWidth = 62;
            this.DgvActivos.Size = new System.Drawing.Size(765, 236);
            this.DgvActivos.TabIndex = 0;
            this.DgvActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvActivos_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(47, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vida util:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor residual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(85, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.Nombre.Location = new System.Drawing.Point(61, 51);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(92, 25);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            // 
            // TxtVidaU
            // 
            this.TxtVidaU.Location = new System.Drawing.Point(157, 189);
            this.TxtVidaU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtVidaU.Name = "TxtVidaU";
            this.TxtVidaU.Size = new System.Drawing.Size(153, 32);
            this.TxtVidaU.TabIndex = 3;
            this.TxtVidaU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVidaU_KeyPress);
            // 
            // TxtValorR
            // 
            this.TxtValorR.Location = new System.Drawing.Point(157, 145);
            this.TxtValorR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtValorR.Name = "TxtValorR";
            this.TxtValorR.Size = new System.Drawing.Size(153, 32);
            this.TxtValorR.TabIndex = 2;
            this.TxtValorR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorR_KeyPress);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(158, 95);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(153, 32);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(161, 48);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 32);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Green;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGuardar.Location = new System.Drawing.Point(17, 23);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(109, 50);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GbInformacion
            // 
            this.GbInformacion.BackColor = System.Drawing.Color.SandyBrown;
            this.GbInformacion.Controls.Add(this.cbEstadoActivo);
            this.GbInformacion.Controls.Add(this.label10);
            this.GbInformacion.Controls.Add(this.txtDescripcion);
            this.GbInformacion.Controls.Add(this.label6);
            this.GbInformacion.Controls.Add(this.TxtNombre);
            this.GbInformacion.Controls.Add(this.TxtValor);
            this.GbInformacion.Controls.Add(this.TxtValorR);
            this.GbInformacion.Controls.Add(this.TxtVidaU);
            this.GbInformacion.Controls.Add(this.Nombre);
            this.GbInformacion.Controls.Add(this.label4);
            this.GbInformacion.Controls.Add(this.label2);
            this.GbInformacion.Controls.Add(this.label3);
            this.GbInformacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.GbInformacion.ForeColor = System.Drawing.Color.Black;
            this.GbInformacion.Location = new System.Drawing.Point(12, 46);
            this.GbInformacion.Name = "GbInformacion";
            this.GbInformacion.Size = new System.Drawing.Size(689, 322);
            this.GbInformacion.TabIndex = 0;
            this.GbInformacion.TabStop = false;
            this.GbInformacion.Text = "Informacion:";
            // 
            // cbEstadoActivo
            // 
            this.cbEstadoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoActivo.FormattingEnabled = true;
            this.cbEstadoActivo.Items.AddRange(new object[] {
            "Mal Estado",
            "Reparacion",
            "Asignado",
            "Disponible"});
            this.cbEstadoActivo.Location = new System.Drawing.Point(157, 236);
            this.cbEstadoActivo.Name = "cbEstadoActivo";
            this.cbEstadoActivo.Size = new System.Drawing.Size(148, 33);
            this.cbEstadoActivo.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(12, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Estado Activo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(328, 78);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(333, 186);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripcion Activo:";
            // 
            // GbAcciones
            // 
            this.GbAcciones.BackColor = System.Drawing.Color.SandyBrown;
            this.GbAcciones.Controls.Add(this.pictureBox1);
            this.GbAcciones.Controls.Add(this.BtnLimpiar);
            this.GbAcciones.Controls.Add(this.BtnGuardar);
            this.GbAcciones.Controls.Add(this.BtnActualizar);
            this.GbAcciones.Controls.Add(this.BtnEliminar);
            this.GbAcciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAcciones.ForeColor = System.Drawing.Color.Black;
            this.GbAcciones.Location = new System.Drawing.Point(720, 46);
            this.GbAcciones.Name = "GbAcciones";
            this.GbAcciones.Size = new System.Drawing.Size(435, 322);
            this.GbAcciones.TabIndex = 1;
            this.GbAcciones.TabStop = false;
            this.GbAcciones.Text = "Acciones:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(250, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 176);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLimpiar.Location = new System.Drawing.Point(134, 23);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(109, 50);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSalir.Location = new System.Drawing.Point(1053, 620);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 30);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1166, 662);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GbAcciones);
            this.Controls.Add(this.GbInformacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvActivos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Activos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActivos)).EndInit();
            this.GbInformacion.ResumeLayout(false);
            this.GbInformacion.PerformLayout();
            this.GbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstadoActivo;
        private System.Windows.Forms.Label label10;
    }
}

