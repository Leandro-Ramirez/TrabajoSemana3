#region Usos
using System;
using Domain.Enum;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Domain.Entities;
using AppCore.Factories;
using Domain.Interfaces;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace practicaDepreciacion
{
    public partial class FrmMetodos : Form
    {
        #region Variable GLobal
        private Activo activo;
        #endregion

        #region Inicializar Componente
        public FrmMetodos(Activo Activo)
        {
            this.activo = Activo;
            InitializeComponent();
            CmbMetodo.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
        }
        #endregion

        #region Seleccionar Metodo
        private void CmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            double total = 0;
            IDepreciacionModel depreciacion = FactoryDeducciones.FactoryDepreciacion((Depreciacion)CmbMetodo.SelectedIndex);
            List<double> depreciaciones = depreciacion.Depreciacion(activo);
            for (int i = 0; i < depreciaciones.Count; i++)
            {
                richTextBox1.Text += $"Depreciacion: {i + 1}: {depreciaciones[i]}\n";
                total += depreciaciones[i];
            }
            richTextBox1.Text += $"Total: {total}\n";
            richTextBox1.Text += $"Valor residual: {activo.ValorResidual}";
        }
        #endregion
    }
}