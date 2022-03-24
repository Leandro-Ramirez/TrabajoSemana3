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

namespace practicaDepreciacion
{
    public partial class FrmEdicion : Form
    {
        #region Get & Set
        public IActivoServices activoServices { get; set; }
        #endregion

        #region Inicializar Componente Formulario
        public FrmEdicion()
        {
            InitializeComponent();
        }
        #endregion

        #region Botones
        #region Aceptar
        private void BtnActualizarD_Click(object sender, EventArgs e)
        {
            Activo activo = new Activo()
            {
                Id = int.Parse(TxtId.Text),
                Nombre = TxtNombre.Text,
                Valor = (float)NudValor.Value,
                VidaUtil = (int)NudVidaU.Value,
                ValorResidual = (float)NudValorR.Value
            };
            activoServices.Update(activo, activo.Id);
            Dispose();
        }
        #endregion

        #region Cancelar
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion
    }
}