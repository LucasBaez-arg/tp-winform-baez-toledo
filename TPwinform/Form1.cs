﻿using System;
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


namespace TPwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = new List<Articulo>();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
               articulos = articuloNegocio.Listar();
               dataGridView1.DataSource = articulos;
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
    }
}
