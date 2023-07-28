using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7GalloRodrigoNicolasBussiness;
using TP7GalloRodrigoNicolasEntities;

namespace TP7GalloRodrigoNicolas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            txtId = null;
        }

        private Empleado empleado = new Empleado();
        public Form1(int ID)
        {
            InitializeComponent();

            empleado = EmpleadoBussiness.ObtenerEmpleado(ID);

            txtId.Text = empleado.Id.ToString();
            txtNombreCompleto.Text = empleado.NombreCompleto;
            txtDni.Text = empleado.DNI;
            txtEdad.Text = empleado.Edad.ToString();
            txtSalario.Text = empleado.Salario.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void casadoNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.VaciarForm();
        }

        private void VaciarForm()
        {
            txtNombreCompleto.Text = null;
            txtDni.Text = null;
            txtEdad.Value = 0;
            txtEdad.Value = 0;
            txtSalario.Value = 0;
            casadoNO.Checked = false;
            casadoSI.Checked = false;
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            VerEmpleados form = new VerEmpleados();
            form.ShowDialog();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreCompleto = txtNombreCompleto.Text;
            string DNI = txtDni.Text;
            int Edad = (int)txtEdad.Value;
            decimal Salario = (decimal)txtSalario.Value;
            bool Casado = false;
            if (casadoSI.Checked)
            {
                 Casado = true;
            }
            else
            {
                 Casado = false;
            }

            EmpleadoBussiness empleado = new EmpleadoBussiness();

            if (txtId == null)
            {
                empleado.CrearEmpleado(NombreCompleto, DNI, Edad, Casado, Salario);
            }
            else
            {
                int Id = Int32.Parse(txtId.Text);
                empleado.EditarEmpleado(Id, NombreCompleto, DNI, Edad, Casado, Salario);
            }
            
            MessageBox.Show("El registro fue cargado con éxto");
            this.VaciarForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
