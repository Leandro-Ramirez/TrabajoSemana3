#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Entities;
#endregion

namespace practicaDepreciacion
{
    public partial class FrmEdicion : Form
    {
        #region Inicializar Formulario
        public FrmEdicion()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones
        #region Boton Actualizar Click
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Activo activo = new Activo()
            {
                Id = int.Parse(TxtId.Text),
                Nombre = TxtNombre.Text,
                Valor = (float)TxtValor.Value,
                ValorResidual = (float)TxtValor.Value,
                VidaUtil = (int)TxtVidaU.Value
            };

            activoServices.Update(activo, activo.Id);
            Dispose();
        }
        #endregion

        #region Boton Cancelar Click
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}