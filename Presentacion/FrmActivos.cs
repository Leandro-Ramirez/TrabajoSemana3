#region Usos
using System;
using System.Linq;
using Domain.Entities;
using AppCore.IServices;
using System.Windows.Forms;
using System.Collections.Generic;
#endregion

namespace practicaDepreciacion
{
    public partial class FrmActivos : Form
    {
        #region Variables Globales
        IActivoServices activoServices;
        List<Activo> activos;
        List<int> activoIds;
        #endregion

        #region Formulario
        #region Inicializar Componente
        public FrmActivos(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }
        #endregion

        #region Cargar 
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvActivos.DataSource = activoServices.Read();
        }
        #endregion
        #endregion

        #region Acciones
        #region Caja De Texto
        #region Nombre
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }
        #endregion

        #region Valor Del Activo
        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        #endregion

        #region Valor Residual
        private void TxtValorR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        #endregion

        #region Vida Util
        private void TxtVidaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        #endregion
        #endregion

        #region Botones
        #region Guardar Click
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool verificado = Verificar();
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
                Limpiar();
            }
        }
        #endregion

        #region Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DgvActivos.DataSource = null;
            DgvActivos.DataSource = activoServices.Read();
        }
        #endregion

        #region Actualizar Click
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvActivos.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmEdicion mod = new FrmEdicion();
            mod.activoServices = activoServices;
            mod.lblID.Text = DgvActivos.CurrentRow.Cells[0].Value.ToString();
            mod.txtNombre.Text = DgvActivos.CurrentRow.Cells[1].Value.ToString();
            mod.txtValorMOD.Text = DgvActivos.CurrentRow.Cells[2].Value.ToString();
            mod.txtVIdaUtilMOD.Text = DgvActivos.CurrentRow.Cells[3].Value.ToString();
            mod.txtValorResidualMOD.Text = DgvActivos.CurrentRow.Cells[4].Value.ToString();

            mod.ShowDialog();

            ActualizarLista();
           
        }
        #endregion

        #region Eliminar Click
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvActivos.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            activos = activoServices.Read();
            activoIds = activos.Select(x => x.Id).ToList();
            activoServices.Delete((int)DgvActivos.CurrentRow.Cells[0].Value, activoIds);

            DgvActivos.DataSource = null;
            DgvActivos.DataSource = activoServices.Read();
        }
        #endregion

        #region Limpiar CLick
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de querer salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #endregion
        #endregion

        #region Metodos
        #region Verificar
        private bool Verificar()
        {
            if (String.IsNullOrEmpty(TxtNombre.Text) || String.IsNullOrEmpty(TxtValor.Text) || String.IsNullOrEmpty(TxtVidaU.Text) || String.IsNullOrEmpty(TxtValorR.Text))
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Limpiar
        private void Limpiar()
        {
            this.TxtNombre.Text = String.Empty;
            this.TxtValor.Text = String.Empty;
            this.TxtValorR.Text = String.Empty;
            this.TxtVidaU.Text = String.Empty;
        }
        #endregion
        #endregion

        #region Data Greed View
        #region Cell Content Click
        private void DgvActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmMetodos depreciacion = new FrmMetodos(activoServices.Read()[e.RowIndex]);
                depreciacion.ShowDialog();
            }
        }
        #endregion
        #endregion


        public void ActualizarLista()
        {
            DgvActivos.DataSource = null;
            DgvActivos.DataSource = activoServices.Read();
        }


    }
}