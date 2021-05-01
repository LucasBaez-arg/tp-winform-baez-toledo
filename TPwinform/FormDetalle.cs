﻿using System;
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
                groupBox1.Enabled = false;
                txtCodigo.Text = this.art.CodigoArticulo;
                txtNombre.Text = this.art.Nombre;
                txtDescripcion.Text = this.art.Descripcion;
                txtImagen.Text = this.art.Imagen;
                txtPrecio.Text = this.art.Precio.ToString();
                BoxCategoria.Text = this.art.Categoria.Descripcion;
                BoxMarca.Text = this.art.Marca.Descripcion;

                ImagenBox.Load(this.art.Imagen);
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ImagenBox.Load("https://definicion.de/wp-content/uploads/2009/02/error.jpg");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

