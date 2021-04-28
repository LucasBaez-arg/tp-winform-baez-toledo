using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        void cargarGrilla()
        {
            List<Articulo> articulos = new List<Articulo>();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                articulos = articuloNegocio.Listar();
                dataGridView1.DataSource = articulos;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Imagen"].Visible = false;
                RecargarImg(articulos[0].Imagen);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            RecargarImg(seleccionado.Imagen);
        }
        private void RecargarImg(string img)
        {
            pictureBox1.Load(img);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
            cargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                articuloNegocio.Eliminar(seleccionado.Id);
                MessageBox.Show("Articulo Eliminado");
                cargarGrilla();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;

                FormModificar modificar = new FormModificar(seleccionado);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
