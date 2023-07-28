using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6GalloRodrigoNicolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.VaciarForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.ToString() == "" || 
                txtAutor.Text.ToString() == "" || 
                txtPaginas.Text.ToString() == "" || 
                txtPrecio.Text.ToString() == "")
            {
                MessageBox.Show("Todos los campos deben estar completos");
            }

            Libro libro = new Libro();
            libro.SetNombre(txtNombre.Text);
            libro.SetAutor(txtAutor.Text);
            libro.SetGenero(comboGenero.Text);
            libro.SetPaginas(Int32.Parse(txtPaginas.Text));
            libro.SetPrecio(float.Parse(txtPrecio.Text));
            libro.SetImportado(chkImportado.Checked);

            lstAlumnos.Items.Add(libro.GetLibroCompleto());
            this.VaciarForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.VaciarForm();
        }

        private void VaciarForm()
        {
            txtAutor.Text = null;
            txtPrecio.Text = null;
            txtNombre.Text = null;
            txtPaginas.Text = null;
        }

        private void txtPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                txtPaginas.Text = null;
                MessageBox.Show("Solo deben ingresar números");
                txtPaginas.Text = null;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                txtPrecio.Text = null;
                MessageBox.Show("Solo deben ingresar números");
                txtPrecio.Text = null;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
