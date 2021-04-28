using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class FormAgregar : Form
    {

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio listNegocio = new CategoriaNegocio();
            MarcaNegocio listMarca = new MarcaNegocio();
            try
            {
                BoxMarca.DataSource = listMarca.listar();
                BoxCategoria.DataSource = listNegocio.listar();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            Articulo art = new Articulo();
            try
            {
                art.CodigoArticulo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Imagen = txtImagen.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);
                art.Categoria = (Categoria)BoxCategoria.SelectedItem;
                art.Marca = (Marca)BoxMarca.SelectedItem;

                artNegocio.Agregar(art);
                MessageBox.Show("Se agrego articulo");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                Close();
            }
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
