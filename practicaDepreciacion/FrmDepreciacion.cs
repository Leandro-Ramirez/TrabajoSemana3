#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using Domain.Enum;
using System.Drawing;
using Domain.Entities;
using AppCore.Factories;
using Domain.Interfaces;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Presentacion
{
    public partial class FrmDepreciacion : Form
    {
        private Activo activo;
        public FrmDepreciacion(Activo Activo)
        {
            this.activo = Activo;
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetValues(typeof(Depreciacion)).Cast<object>().ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
            double total = 0;
            IDepreciacionModel depreciacion = FactoryDeducciones.FactoryDepreciacion((Depreciacion)comboBox1.SelectedIndex);
            List<double> depreciaciones = depreciacion.Depreciacion(activo);
            for(int i=0; i<depreciaciones.Count;i++)
            {
                richTextBox1.Text += $"Depreciacion: {i + 1}: {depreciaciones[i]}\n";
                total += depreciaciones[i];
            }
            richTextBox1.Text += $"Total: {total}\n";
            richTextBox1.Text += $"Valor residual: {activo.ValorResidual}";
        }

        #region Extras
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}