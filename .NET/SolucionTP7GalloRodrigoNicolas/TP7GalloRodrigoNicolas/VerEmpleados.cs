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
    public partial class VerEmpleados : Form
    {
        public VerEmpleados()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int id = (int)this.dgListaEmpleados.Rows[e.RowIndex].Cells["Id"].Value;

            if (this.dgListaEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                Form1 formempleado = new Form1(id);
                formempleado.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Empleado_formclosed);

                formempleado.ShowDialog();
            }
            else if (this.dgListaEmpleados.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (MessageBox.Show("Esta seguro de eliminar el empleado?", "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EmpleadoBussiness.EliminarEmpleado(id);
                    MessageBox.Show("Se elimino correctamente el empleado");
                    CargarEmpleados();
                }
            }
        }

        private void VerEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void Empleado_formclosed(object sender, FormClosedEventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            EmpleadoBussiness empleado = new EmpleadoBussiness();
            this.dgListaEmpleados.Columns["id"].Visible = false;

            ResponseEmpleados response = empleado.ListarEmpleados();

            if (response.error == null)
            {
                dgListaEmpleados.DataSource = response.listado;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al conectar con la base de datos");
            }


        }

        private void dgListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int id = (int)this.dgListaEmpleados.Rows[e.RowIndex].Cells["Id"].Value;

            if (this.dgListaEmpleados.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                Form1 formempleado = new Form1(id);
                formempleado.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Empleado_formclosed);

                formempleado.ShowDialog();
            }
            else if (this.dgListaEmpleados.Columns[e.ColumnIndex].Name == "BtnEliminar")
            {
                if (MessageBox.Show("Esta seguro de eliminar el empleado?", "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EmpleadoBussiness.EliminarEmpleado(id);
                    MessageBox.Show("Se elimino correctamente el empleado");
                    CargarEmpleados();
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string NommbreCompleto = txtNombreCompletoFiltro.Text;
            EmpleadoBussiness empleado = new EmpleadoBussiness();
            dgListaEmpleados.DataSource = empleado.ListarEmpleadosConFiltro(NommbreCompleto);
            this.dgListaEmpleados.Columns["id"].Visible = false;
        }
    }
}
