using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listarArticulos();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
           pbxArticulo.Load(listaArticulos[0].ImagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

                 Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
                 cargarImagen(seleccionado.ImagenUrl);           
        }
        //Metodo para cargar imagenes
        private void cargarImagen(string imagen)
        {
            try
            {
                 pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                cargarImagen("https://louisville.edu/history/images/noimage.jpg/image");
            }
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmDetalles detalles = new frmDetalles();
            detalles.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar modificar = new frmModificar();    
            modificar.ShowDialog();
        }
    }
}

