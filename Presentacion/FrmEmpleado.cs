using AppCore.IServices;
using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmEmpleado : Form
    {
        IEmpledoServices empleadoServices;
        List<Empleado> empleado;
        List<int> EmpleadosIds;




        public FrmEmpleado(IEmpledoServices Empledoservices)
        {

            this.empleadoServices = Empledoservices;
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }




        public void Clean()
        {
            txtNombreEmpleado.Clear();
            txtCedula.Clear();
            txtCodigoEmpleado.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            cbEstadoEmpleado.SelectedIndex = -1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool verificado = VerificarCampos();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {
                Empleado empleadocreado = new Empleado()
                {
                    Nombres = txtNombreEmpleado.Text,
                    Cedula = txtCedula.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    Email = txtEmail.Text,
                    CodigoEmpleado = int.Parse(txtCodigoEmpleado.Text),
                    Estado = (Estado)Enum.GetValues(typeof(Estado))
                                                            .GetValue(cbEstadoEmpleado.SelectedIndex)


                };

                empleadoServices.Add(empleadocreado);
                ActualizarLista();
                Clean();
            }
        }

        public bool VerificarCampos()
        {
            if (String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtCodigoEmpleado.Text) || String.IsNullOrEmpty(txtNombreEmpleado.Text) ||
                String.IsNullOrEmpty(cbEstadoEmpleado.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                return false;
            }


            return true;
        }

        public void ActualizarLista()
        {
            DgvEmpleado.DataSource = null;
            DgvEmpleado.DataSource = empleadoServices.Read();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvEmpleado.CurrentRow.Selected == false)
            {
                MessageBox.Show("Debe seleccionar un activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            empleado = empleadoServices.Read();
            EmpleadosIds = empleado.Select(x => x.Id).ToList();
            empleadoServices.Delete((int)DgvEmpleado.CurrentRow.Cells[0].Value, EmpleadosIds);

            ActualizarLista();
        }

        private void DgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de querer salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void TxtNombreEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TxtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

        private void TxtCodigoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            DgvEmpleado.DataSource = empleadoServices.Read();
        }
    }
}










