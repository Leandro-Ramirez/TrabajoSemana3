#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Domain.Entities;
using AppCore.IServices;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Presentacion
{
    public partial class FrmActivo : Form
    {
        #region Variables Globales
        IActivoServices activoServices;
        #endregion

        #region Acciones del Formulario
        #region Inicializar
        public FrmActivo(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }
        #endregion

        #region Cargar
        private void FrmActivo_Load(object sender, EventArgs e)
        {
            DgvActivo.DataSource = activoServices.Read();
        }
        #endregion
        #endregion

        #region Interacciones
        #region Texto 
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

        private void TxtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void TxtValorR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void TxtVidaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        #endregion

        #region Otros
        private void DgvActivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                depreciacion.ShowDialog();
            }
        }
        #endregion

        #region Botones
        #region Enviar Click
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {
                Activo activo = new Activo()
                {
                    Nombre = TxtNombre.Text,
                    Valor = double.Parse(TxtValor.Text),
                    ValorResidual = double.Parse(TxtValorR.Text),
                    VidaUtil = int.Parse(TxtVidaU.Text)
                };
                activoServices.Add(activo);
                limpiar();
            }
        }
        #endregion

        #region Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DgvActivo.DataSource = null;
            DgvActivo.DataSource = activoServices.Read();
        }
        #endregion

        #region Actualizar CLick
        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Eliminar CLick
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de querer salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Limpiar CLick
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        #endregion

        #region Salir CLick
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        #endregion
        #endregion
        #endregion

        #region Metodos
        #region Verificar
        private bool verificar()
        {
            if (String.IsNullOrEmpty(TxtNombre.Text) || String.IsNullOrEmpty(TxtValor.Text) || String.IsNullOrEmpty(TxtVidaU.Text) || String.IsNullOrEmpty(TxtValorR.Text))
            {
              
                return false;
            }
            return true;
        }
        #endregion

        #region Limpieza
        private void limpiar()
        {
            this.TxtNombre.Text = String.Empty;
            this.TxtValor.Text = String.Empty;
            this.TxtValorR.Text = String.Empty;
            this.TxtVidaU.Text = String.Empty;
        }


        #endregion

        #endregion

        
    }
}