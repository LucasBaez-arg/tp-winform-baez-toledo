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
    public partial class FormDetalle : Form
    {
        private Articulo art;
        public FormDetalle(Articulo art)
        {
            InitializeComponent();
            this.art = art;
        }

        private void FormDetalle_Load(object sender, EventArgs e)
        {

            try
            {

                MostrarCodigo.Text = this.art.CodigoArticulo;
                MostrarNombre.Text = this.art.Nombre;
                MostrarDescripcion.Text = this.art.Descripcion;
                MostrarUrl.Text = this.art.Imagen;
                MostrarPrecio.Text = this.art.Precio.ToString();
                MostrarCategoria.Text = this.art.Categoria.Descripcion;
                MostrarMarca.Text = this.art.Marca.Descripcion;

                CargarImg.Load(this.art.Imagen);
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                CargarImg.Load("https://definicion.de/wp-content/uploads/2009/02/error.jpg");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

