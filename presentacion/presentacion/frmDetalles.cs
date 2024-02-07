using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmDetalles : Form
    {
        private Articulo articulo = null;
        public frmDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }
        private void frmDetalles_Load(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                lblCodDatos.Text = articulo.codArticulo;
                lblNombreDatos.Text = articulo.Nombre;
                lblDescDatos.Text = articulo.Descripcion;
                lblPrecioDatos.Text = articulo.Precio.ToString();
                lblImagenDatos.Text = articulo.ImagenUrl;
                lblMarcaDatos.Text = articulo.Marca.Descripcion.ToString();
                lblCatDatos.Text =  articulo.Categoria.Descripcion.ToString();
                cargarImagen(lblImagenDatos.Text);
            }
        }

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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregar modificar = new frmAgregar(articulo);
            modificar.ShowDialog();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
