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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarDesplegables();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
                if(dgvArticulos.CurrentRow != null)
            {
                 Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
                 cargarImagen(seleccionado.ImagenUrl);           
            }
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
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.RowHeadersVisible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            cargar();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalles detalles = new frmDetalles(seleccionado);
            detalles.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();
            try
            {
                DialogResult respuesta = MessageBox.Show("Se eliminara permanentemente el articulo, ¿Continuar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                }

                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaBuscar;
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 2)
            {
                listaBuscar = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.codArticulo.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaBuscar = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaBuscar;
            ocultarColumnas();
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //ESTO HAY QUE CAMBIARLO TODO CON EL NUEVO MODELO DE FILTRO AVANZADO
                int marca = (int)cboMarca.SelectedValue;
                int categoria = (int)cboCategoria.SelectedValue;
                string cboRangoPrecio = cboPrecio.SelectedItem.ToString();
                string precio = txtPrecio.Text;
                dgvArticulos.DataSource = negocio.filtrar(marca, categoria, cboRangoPrecio, precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarDesplegables()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            cboCategoria.DataSource = categoria.listarCategorias();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Descripcion";

            cboMarca.DataSource = marca.listarMarcas();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";

            cboPrecio.Items.Clear();
            cboPrecio.Items.Add("Hasta");
            cboPrecio.Items.Add("Desde");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //borrar esto

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //borrar esto

        }
        //private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MarcaNegocio marca = new MarcaNegocio();
        //    CategoriaNegocio categoria = new CategoriaNegocio();
        //    string campo = cboMarca.SelectedItem.ToString();

        //    switch (campo)
        //    {
        //        case "Categoria":
        //            {
        //                cboCategoria.DataSource = categoria.listarCategorias();
        //                cboCategoria.ValueMember = "Id";
        //                cboCategoria.DisplayMember = "Descripcion";
        //                campo = "c.Id = ";
        //            }
        //        break;
        //        case "Marca":
        //            {
        //                cboCategoria.DataSource = marca.listarMarcas();
        //                cboCategoria.ValueMember = "Id";
        //                cboCategoria.DisplayMember = "Descripcion";
        //            }
        //            break;
        //        case "Precio":
        //            {
        //                cboCategoria.DataSource = null;
        //                cboCategoria.Items.Clear();
        //                cboCategoria.Items.Add("Hasta");
        //                cboCategoria.Items.Add("Desde");
        //            }
        //        break;
        //    }


        //}




        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //borrar esto
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {
            //borrar esto

        }

        private void txtFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {
            //borrar esto
        }

        private void lblFiltroAvanzado_Click(object sender, EventArgs e)
        {
            //borrar esto
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //borrar esto
        }
    }
}