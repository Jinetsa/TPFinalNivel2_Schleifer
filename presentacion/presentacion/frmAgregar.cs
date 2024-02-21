using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace presentacion
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            Text = "Modificar artículo";
            this.articulo = articulo;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            cargarDesplegables();
            if(articulo != null)
            {
                txtCodigo.Text = articulo.codArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                txtUrlImagen.Text = articulo.ImagenUrl;
                cbxMarca.SelectedValue = articulo.Marca.Id;
                cbxCategoria.SelectedValue = articulo.Categoria.Id;
                cargarImagen(articulo.ImagenUrl);

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                articulo = new Articulo();
                articulo.codArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                if(validarPrecio(txtPrecio.Text.ToString()))
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                if (validarCampos())
                {
                    guardarImagen();
                    if (articulo.Id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Articulo agregado exitosamente");
                    }
                }
                else
                    return;

                Close();                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
        private void cargarDesplegables()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cbxMarca.DataSource = marca.listarMarcas();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoria.listarCategorias();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            string imagen = txtUrlImagen.Text;
            cargarImagen(imagen);
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            crearCarpeta();
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ConfigurationManager.AppSettings["Imagenes-Catalogo"] + archivo.SafeFileName))
                    MessageBox.Show("La imagen ya existe en la carpeta, seleccione otra por favor.");
            else
            { 
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
                               
            }
        }
        private void crearCarpeta()
        {
            if (!Directory.Exists(ConfigurationManager.AppSettings["Imagenes-Catalogo"]))
            {
                DialogResult respuesta = MessageBox.Show("Se creara la carpeta 'Imagenes-Catalogo' en el disco 'C:\'", "Crear carpeta");
                if (respuesta == DialogResult.OK)
                    Directory.CreateDirectory(ConfigurationManager.AppSettings["Imagenes-Catalogo"]);
                else
                {
                    Close();
                }
            }
            return;
        }
        private bool validarCampos()
        {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese todos los campos obligatorios por favor");
                    return false;
                }
            return true;
        }
        private bool validarPrecio(string cadena)
        {
            decimal precio;
            if (!decimal.TryParse(cadena, out precio))
            {
                MessageBox.Show("Ingrese un precio válido para el artículo");
                return false;
            }
            else if (precio < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
                return false;
            }
            else if (cadena.Count(c => c == '.') > 1)
            {
                MessageBox.Show("El precio solo puede contener un punto decimal");
                return false;
            }
            else if (cadena.Contains('.') && cadena.Substring(cadena.IndexOf('.') + 1).Length > 2) 
            {
                MessageBox.Show("El precio solo puede tener hasta dos decimales");
                return false;
            }
           return true;
        }

        private void guardarImagen()
        {
            if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
            {
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes-Catalogo"] + archivo.SafeFileName);
                articulo.ImagenUrl = ConfigurationManager.AppSettings["Imagenes-Catalogo"] + archivo.SafeFileName;
            }
            else
                articulo.ImagenUrl = txtUrlImagen.Text;
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            validarPrecio(txtPrecio.Text);
            return;
        }

        private void lblObligatorios_Click(object sender, EventArgs e)
        {

        }
    }
}
