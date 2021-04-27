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
    }
}
