namespace Presentacion
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbAcciones = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GbInformacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvEmpleado = new System.Windows.Forms.DataGridView();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstadoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnSalir.Location = new System.Drawing.Point(803, 460);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 30);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // GbAcciones
            // 
            this.GbAcciones.BackColor = System.Drawing.Color.SandyBrown;
            this.GbAcciones.Controls.Add(this.pictureBox1);
            this.GbAcciones.Controls.Add(this.BtnLimpiar);
            this.GbAcciones.Controls.Add(this.BtnMostrar);
            this.GbAcciones.Controls.Add(this.BtnGuardar);
            this.GbAcciones.Controls.Add(this.BtnActualizar);
            this.GbAcciones.Controls.Add(this.BtnEliminar);
            this.GbAcciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAcciones.ForeColor = System.Drawing.Color.Black;
            this.GbAcciones.Location = new System.Drawing.Point(728, 52);
            this.GbAcciones.Name = "GbAcciones";
            this.GbAcciones.Size = new System.Drawing.Size(558, 322);
            this.GbAcciones.TabIndex = 9;
            this.GbAcciones.TabStop = false;
            this.GbAcciones.Text = "Acciones:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(331, 48);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(17, 146);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(109, 50);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.Yellow;
            this.BtnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnMostrar.Location = new System.Drawing.Point(132, 22);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(109, 50);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
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
            // 
            // GbInformacion
            // 
            this.GbInformacion.BackColor = System.Drawing.Color.SandyBrown;
            this.GbInformacion.Controls.Add(this.txtCedula);
            this.GbInformacion.Controls.Add(this.label3);
            this.GbInformacion.Controls.Add(this.txtEmail);
            this.GbInformacion.Controls.Add(this.label2);
            this.GbInformacion.Controls.Add(this.txtTelefono);
            this.GbInformacion.Controls.Add(this.label9);
            this.GbInformacion.Controls.Add(this.cbEstadoEmpleado);
            this.GbInformacion.Controls.Add(this.txtNombreEmpleado);
            this.GbInformacion.Controls.Add(this.txtCodigoEmpleado);
            this.GbInformacion.Controls.Add(this.label5);
            this.GbInformacion.Controls.Add(this.label8);
            this.GbInformacion.Controls.Add(this.label7);
            this.GbInformacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.GbInformacion.ForeColor = System.Drawing.Color.Black;
            this.GbInformacion.Location = new System.Drawing.Point(20, 52);
            this.GbInformacion.Name = "GbInformacion";
            this.GbInformacion.Size = new System.Drawing.Size(689, 322);
            this.GbInformacion.TabIndex = 6;
            this.GbInformacion.TabStop = false;
            this.GbInformacion.Text = "Registro Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro de Empleado";
            // 
            // DgvEmpleado
            // 
            this.DgvEmpleado.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEmpleado.GridColor = System.Drawing.Color.Maroon;
            this.DgvEmpleado.Location = new System.Drawing.Point(20, 403);
            this.DgvEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvEmpleado.Name = "DgvEmpleado";
            this.DgvEmpleado.RowHeadersWidth = 62;
            this.DgvEmpleado.Size = new System.Drawing.Size(765, 236);
            this.DgvEmpleado.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(222, 192);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(153, 32);
            this.txtTelefono.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(108, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Telefono:";
            // 
            // cbEstadoEmpleado
            // 
            this.cbEstadoEmpleado.FormattingEnabled = true;
            this.cbEstadoEmpleado.Items.AddRange(new object[] {
            "Subsidio",
            "Activo",
            "Vacaciones"});
            this.cbEstadoEmpleado.Location = new System.Drawing.Point(222, 141);
            this.cbEstadoEmpleado.Name = "cbEstadoEmpleado";
            this.cbEstadoEmpleado.Size = new System.Drawing.Size(148, 33);
            this.cbEstadoEmpleado.TabIndex = 21;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(217, 41);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(153, 32);
            this.txtNombreEmpleado.TabIndex = 16;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(217, 85);
            this.txtCodigoEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(153, 32);
            this.txtCodigoEmpleado.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(32, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "NombreEmpleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(136, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(35, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Codigo Empleado:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(217, 242);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 32);
            this.txtEmail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(103, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Email:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(509, 41);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(153, 32);
            this.txtCedula.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(420, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cedula:";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 654);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GbAcciones);
            this.Controls.Add(this.GbInformacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvEmpleado);
            this.Name = "FrmEmpleado";
            this.Text = "Registro de Empleados";
            this.GbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbInformacion.ResumeLayout(false);
            this.GbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GbAcciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GbInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvEmpleado;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEstadoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}